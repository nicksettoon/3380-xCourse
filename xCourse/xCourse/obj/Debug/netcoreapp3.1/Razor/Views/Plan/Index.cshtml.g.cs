#pragma checksum "C:\Users\holde\Documents\GitHub\3380-xCourse\xCourse\xCourse\Views\Plan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e26cb4989d0df0c4583cd46abdc89af6ba5b4ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Plan_Index), @"mvc.1.0.view", @"/Views/Plan/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\holde\Documents\GitHub\3380-xCourse\xCourse\xCourse\Views\_ViewImports.cshtml"
using xCourse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\holde\Documents\GitHub\3380-xCourse\xCourse\xCourse\Views\_ViewImports.cshtml"
using xCourse.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e26cb4989d0df0c4583cd46abdc89af6ba5b4ed", @"/Views/Plan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e372bd050dbacbc928d4f4a0d9d293fdffe1e74e", @"/Views/_ViewImports.cshtml")]
    public class Views_Plan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlanModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("init()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\holde\Documents\GitHub\3380-xCourse\xCourse\xCourse\Views\Plan\Index.cshtml"
  
    ViewData["Title"] = "Plan | xCourse";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e26cb4989d0df0c4583cd46abdc89af6ba5b4ed3785", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://cdn.jsdelivr.net/npm/gojs/release/go.js""></script>

    <script>

  // this controls whether the layout is horizontal and the layer bands are vertical, or vice-versa:
  var HORIZONTAL = true;  // this constant parameter can only be set here, not dynamically

    // Perform a LayeredDigraphLayout where commitLayers is overridden to modify the background Part whose key is ""_BANDS"".
    function BandedLDLayout() {
    go.LayeredDigraphLayout.call(this);
    }
    go.Diagram.inherit(BandedLDLayout, go.LayeredDigraphLayout);


    BandedLDLayout.prototype.assignLayers = function() {
    go.LayeredDigraphLayout.prototype.assignLayers.call(this);
    var maxlayer = 7;
    // now assign specific layers
    var it = this.network.vertexes.iterator;
    while (it.next()) {
    var v = it.value;
    if (v.node !== null) {
        var lay = v.node.data.layer;
        if (typeof lay === ""number"" && lay >= 0 && lay <= maxlayer) {
        v.layer = lay");
                WriteLiteral(@";
        }
    }
    }
    };


    BandedLDLayout.prototype.commitLayers = function(layerRects, offset) {
    // update the background object holding the visual ""bands""
    var bands = this.diagram.findPartForKey(""_BANDS"");
    if (bands) {
    var model = this.diagram.model;
    bands.location = this.arrangementOrigin.copy().add(offset);

    // make each band visible or not, depending on whether there is a layer for it
    for (var it = bands.elements; it.next(); ) {
        var idx = it.key;
        var elt = it.value;  // the item panel representing a band
        elt.visible = idx < layerRects.length;
    }

    // set the bounds of each band via data binding of the ""bounds"" property
    var arr = bands.data.itemArray;
    for (var i = 0; i < layerRects.length; i++) {
        var itemdata = arr[i];
        if (itemdata) {
        model.setDataProperty(itemdata, ""bounds"", layerRects[i]);
        }
    }
    }
    };
    // end BandedLDLayout


    function init() {
   ");
                WriteLiteral(@" if (window.goSamples) goSamples();  // init for these samples -- you don't need to call this
    var $ = go.GraphObject.make;

    myDiagram = $(go.Diagram, ""myDiagramDiv"",
                {
                    initialAutoScale: go.Diagram.Uniform,
                    initialContentAlignment: go.Spot.Center,
                    layout: $(BandedLDLayout,
                            {
                                direction: HORIZONTAL ? 0 : 90
                            }),  // custom layout is defined above
                    ""undoManager.isEnabled"": true
                });

    myDiagram.nodeTemplate =
    $(go.Node, ""Auto"",
        $(go.Shape, ""RoundedRectangle"",
        { fill: ""white"" }),
        $(go.Panel, ""Vertical"",
        new go.Binding(""itemArray"", ""items""),
        {
            itemTemplate:
            $(go.Panel, ""Auto"",
                { margin: 1 },
            $(go.TextBlock, new go.Binding(""text"", """"),
                { margin: 1 })

            )

       ");
                WriteLiteral(@" }

        )
    );

    // There should be at most a single object of this category.
    // This Part will be modified by BandedLDLayout.commitLayers to display visual ""bands""
    // where each ""layer"" is a layer of the tree.
    // This template is parameterized at load time by the HORIZONTAL parameter.
    // You also have the option of showing rectangles for the layer bands or
    // of showing separator lines between the layers, but not both at the same time,
    // by commenting in/out the indicated code.
    myDiagram.nodeTemplateMap.add(""Bands"",
    $(go.Part, ""Position"",
        new go.Binding(""itemArray""),
        {
        isLayoutPositioned: false,  // but still in document bounds
        locationSpot: new go.Spot(0, 0, HORIZONTAL ? 0 : 16, HORIZONTAL ? 16 : 0),  // account for header height
        layerName: ""Background"",
        pickable: false,
        selectable: false,
        itemTemplate:
            $(go.Panel, HORIZONTAL ? ""Vertical"" : ""Horizontal"",
            ne");
                WriteLiteral(@"w go.Binding(""position"", ""bounds"", function(b) { return b.position; }),
            $(go.TextBlock,
                {
                angle: HORIZONTAL ? 0 : 270,
                textAlign: ""center"",
                wrap: go.TextBlock.None,
                font: ""bold 11pt sans-serif"",
                background: $(go.Brush, ""Linear"", { 0: ""white"", 1: go.Brush.darken(""white"") })
                },
                new go.Binding(""text""),
                // always bind ""width"" because the angle does the rotation
                new go.Binding(""width"", ""bounds"", function(r) { return HORIZONTAL ? r.width : r.height; })
            ),
            // option 1: rectangular bands:
            $(go.Shape,
                { stroke: null, strokeWidth: 0 },
                new go.Binding(""desiredSize"", ""bounds"", function(r) { return r.size; }),
                new go.Binding(""fill"", ""itemIndex"", function(i) { return i % 2 == 0 ? ""whitesmoke"" : go.Brush.darken(""whitesmoke""); }).ofObject())
            //");
                WriteLiteral(@" option 2: separator lines:
            //(HORIZONTAL
            //  ? $(go.Shape, ""LineV"",
            //      { stroke: ""gray"", alignment: go.Spot.TopLeft, width: 1 },
            //      new go.Binding(""height"", ""bounds"", function(r) { return r.height; }),
            //      new go.Binding(""visible"", ""itemIndex"", function(i) { return i > 0; }).ofObject())
            //  : $(go.Shape, ""LineH"",
            //      { stroke: ""gray"", alignment: go.Spot.TopLeft, height: 1 },
            //      new go.Binding(""width"", ""bounds"", function(r) { return r.width; }),
            //      new go.Binding(""visible"", ""itemIndex"", function(i) { return i > 0; }).ofObject())
            //)
            )
        }
    ));

    myDiagram.linkTemplate =
    $(go.Link,
        $(go.Shape));  // simple black line, no arrowhead needed

    // define the tree node data
    const nodeDataArray = [
    { // this is the information needed for the headers of the bands
        key: ""_BANDS"",
        category: ");
                WriteLiteral(@"""Bands"",
        itemArray: [
        { text: ""Fall 1"" },
        { text: ""Spring 2"" },
        { text: ""Fall 3"" },
        { text: ""Spring 4"" },
        { text: ""Fall 5"" },
        { text: ""Spring 6"" },
        { text: ""Fall 7"" },
        { text: ""Spring 8"" }
        ]
    },
        ");
#nullable restore
#line 171 "C:\Users\holde\Documents\GitHub\3380-xCourse\xCourse\xCourse\Views\Plan\Index.cshtml"
   Write(Html.Raw(@Model.Nodes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ];\r\n\r\n\r\n\r\n    var linkDataArray = [ ");
#nullable restore
#line 176 "C:\Users\holde\Documents\GitHub\3380-xCourse\xCourse\xCourse\Views\Plan\Index.cshtml"
                     Write(Html.Raw(@Model.Links));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ];\r\n\r\n    myDiagram.model = new go.GraphLinksModel(nodeDataArray, linkDataArray);\r\n    }\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n<h1 style=\"text-align:center;\"> Plan your degree!</h1>\r\n\r\n<h2 style=\"text-align:center;\">");
#nullable restore
#line 187 "C:\Users\holde\Documents\GitHub\3380-xCourse\xCourse\xCourse\Views\Plan\Index.cshtml"
                          Write(Model.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e26cb4989d0df0c4583cd46abdc89af6ba5b4ed12570", async() => {
                WriteLiteral(@"
    <br />
    <div class=""row"">
        <div class=""col-3"">
            <div class=""container-sm align-self-start"" id=""purple"">
                <h2> <span class=""tab1""></span> Select Degree</h2>
                <ul class=""navbar-nav flex-column"" id=""notHidden"">
                    <li class=""dropdown dropright"">
                        <div type=""button"" class=""btn"" data-toggle=""dropdown"">
                            College of Engineering
                        </div>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#BE"">Biological & Agricultural Engineering</a>
                            <a class=""dropdown-item"" href=""#CE"">Civil Engineering</a>
                            <a class=""dropdown-item"" href=""#ChE"">Chemical Engineering</a>
                            <a class=""dropdown-item"" href=""#EEC"">Computer Engineering</a>
                            <a class=""dropdown-item"" href=""plan?CourseAbbrev=CSC SD"">Computer Science (Seco");
                WriteLiteral(@"nd Discipline)</a>
                            <a class=""dropdown-item"" href=""#CSC-CYB"">Computer Science (Cybersecurity Concentration)</a>
                            <a class=""dropdown-item"" href=""#CSC-DSA"">Computer Science (Data Science & Analytics)</a>
                            <a class=""dropdown-item"" href=""#CSC-SEG"">Computer Science (Software Engineering)</a>
                            <a class=""dropdown-item"" href=""#CSC-CCN"">Computer Science (Cloud Computing & Networking)</a>
                            <a class=""dropdown-item"" href=""#CM"">Construction Management</a>
                            <a class=""dropdown-item"" href=""#CM-IEA"">Construction Management - Industry Emphasis Area</a>
                            <a class=""dropdown-item"" href=""#EE"">Electrical Enginerring</a>
                            <a class=""dropdown-item"" href=""#EVEG"">Environmental Engineering</a>
                            <a class=""dropdown-item"" href=""#IE"">Industrial Engineering</a>
                            <a cl");
                WriteLiteral(@"ass=""dropdown-item"" href=""#ME"">Mechanical Engineering</a>
                            <a class=""dropdown-item"" href=""#PETE"">Petroleum Engineering</a>
                        </div>
                    </li>
                    <li class=""dropdown dropright"">
                        <div type=""button"" class=""btn"" data-toggle=""dropdown"">
                            College of Agriculture
                        </div>
                    </li>
                    <li class=""dropdown dropright"">
                        <div type=""button"" class=""btn"" data-toggle=""dropdown"">
                            College of Art & Design
                        </div>
                    </li>
                    <li class=""dropdown dropright"">
                        <div type=""button"" class=""btn"" data-toggle=""dropdown"">
                            College of Business
                        </div>
                    </li>
                    <li class=""dropdown dropright"">
                        <div t");
                WriteLiteral(@"ype=""button"" class=""btn"" data-toggle=""dropdown"">
                            College of the Coast & Enviroment
                        </div>
                    </li>
                    <li class=""dropdown dropright"">
                        <div type=""button"" class=""btn"" data-toggle=""dropdown"">
                            College of Human Sciences & Education
                        </div>
                    </li>
                    <li class=""dropdown dropright"">
                        <div type=""button"" class=""btn"" data-toggle=""dropdown"">
                            Manship School of Mass Communication
                        </div>
                    </li>
                    <li class=""dropdown dropright"">
                        <div type=""button"" class=""btn"" data-toggle=""dropdown"">
                            College of Music & Dramatic Arts
                        </div>
                    </li>
                    <li class=""dropdown dropright"">
                        <div");
                WriteLiteral(@" type=""button"" class=""btn"" data-toggle=""dropdown"">
                            College of Science
                        </div>
                    </li>
                    <li class=""dropdown dropright"">
                        <div type=""button"" class=""btn"" data-toggle=""dropdown"">
                            University College
                        </div>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""col-8"">
            <div id=""myDiagramDiv"" style=""width: 1200px; height: 800px; border: 1px solid black;""></div>
        </div>
    </div>
    
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlanModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
