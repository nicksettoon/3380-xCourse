// this controls whether the layout is horizontal and the layer bands are vertical, or vice-versa:
var HORIZONTAL = true;  // this constant parameter can only be set here, not dynamically

// Perform a LayeredDigraphLayout where commitLayers is overridden to modify the background Part whose key is "_BANDS".
function BandedLDLayout() {
    go.LayeredDigraphLayout.call(this);
}

go.Diagram.inherit(BandedLDLayout, go.LayeredDigraphLayout);


BandedLDLayout.prototype.assignLayers = function () {
    go.LayeredDigraphLayout.prototype.assignLayers.call(this);
    var maxlayer = 7;
    // now assign specific layers
    var it = this.network.vertexes.iterator;
    while (it.next()) {
        var v = it.value;
        if (v.node !== null) {
            var lay = v.node.data.layer;
            if (typeof lay === "number" && lay >= 0 && lay <= maxlayer) {
                v.layer = lay;
            }
        }
    }
};


BandedLDLayout.prototype.commitLayers = function (layerRects, offset) {
    // update the background object holding the visual "bands"
    var bands = this.diagram.findPartForKey("_BANDS");
    if (bands) {
        var model = this.diagram.model;
        bands.location = this.arrangementOrigin.copy().add(offset);

        // make each band visible or not, depending on whether there is a layer for it
        for (var it = bands.elements; it.next();) {
            var idx = it.key;
            var elt = it.value;  // the item panel representing a band
            elt.visible = idx < layerRects.length;
        }

        // set the bounds of each band via data binding of the "bounds" property
        var arr = bands.data.itemArray;
        for (var i = 0; i < layerRects.length; i++) {
            var itemdata = arr[i];
            if (itemdata) {
                model.setDataProperty(itemdata, "bounds", layerRects[i]);
            }
        }
    }
};
// end BandedLDLayout


function init() {
    var $ = go.GraphObject.make;

    myDiagram = $(go.Diagram, "myDiagramDiv",
        {
            initialAutoScale: go.Diagram.Uniform,
            initialContentAlignment: go.Spot.Center,
            layout: $(BandedLDLayout,
                {
                    direction: HORIZONTAL ? 0 : 90
                }),  // custom layout is defined above
            "undoManager.isEnabled": true
        });

    myDiagram.nodeTemplate =
        $(go.Node, "Auto",
            $(go.Shape, "RoundedRectangle",
                { fill: "white" }),
            $(go.Panel, "Vertical",
                new go.Binding("itemArray", "items"),
                {
                    itemTemplate:
                        $(go.Panel, "Auto",
                            { margin: 1 },
                            $(go.TextBlock, new go.Binding("text", ""),
                                { margin: 1 })

                        )

                }

            )
        );

    myDiagram.nodeTemplateMap.add("Bands",
        $(go.Part, "Position",
            new go.Binding("itemArray"),
            {
                isLayoutPositioned: false,  // but still in document bounds
                locationSpot: new go.Spot(0, 0, HORIZONTAL ? 0 : 16, HORIZONTAL ? 16 : 0),  // account for header height
                layerName: "Background",
                pickable: false,
                selectable: false,
                itemTemplate:
                    $(go.Panel, HORIZONTAL ? "Vertical" : "Horizontal",
                        new go.Binding("position", "bounds", function (b) { return b.position; }),
                        $(go.TextBlock,
                            {
                                angle: HORIZONTAL ? 0 : 270,
                                textAlign: "center",
                                wrap: go.TextBlock.None,
                                font: "bold 11pt sans-serif",
                                background: $(go.Brush, "Linear", { 0: "white", 1: go.Brush.darken("white") })
                            },
                            new go.Binding("text"),
                            // always bind "width" because the angle does the rotation
                            new go.Binding("width", "bounds", function (r) { return HORIZONTAL ? r.width : r.height; })
                        ),
                        $(go.Shape,
                            { stroke: null, strokeWidth: 0 },
                            new go.Binding("desiredSize", "bounds", function (r) { return r.size; }),
                            new go.Binding("fill", "itemIndex", function (i) { return i % 2 == 0 ? "whitesmoke" : go.Brush.darken("whitesmoke"); }).ofObject())
                    )
            }
        ));

    myDiagram.linkTemplate =
        $(go.Link,
            $(go.Shape));  // simple black line, no arrowhead needed

    // define the tree node data
    const nodeDataArray = [
        { // this is the information needed for the headers of the bands
            key: "_BANDS",
            category: "Bands",
            itemArray: [
                { text: "Fall 1" },
                { text: "Spring 2" },
                { text: "Fall 3" },
                { text: "Spring 4" },
                { text: "Fall 5" },
                { text: "Spring 6" },
                { text: "Fall 7" },
                { text: "Spring 8" }
            ]
        },
        {}
        ];



    var linkDataArray = [  ];

    myDiagram.model = new go.GraphLinksModel(nodeDataArray, linkDataArray);
}