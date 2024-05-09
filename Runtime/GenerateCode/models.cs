
// 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class mxfile
{

    private mxfileDiagram diagramField;

    private string hostField;

    private System.DateTime modifiedField;

    private string agentField;

    private string etagField;

    private string versionField;

    private string typeField;

    /// <remarks/>
    public mxfileDiagram diagram
    {
        get
        {
            return this.diagramField;
        }
        set
        {
            this.diagramField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string host
    {
        get
        {
            return this.hostField;
        }
        set
        {
            this.hostField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime modified
    {
        get
        {
            return this.modifiedField;
        }
        set
        {
            this.modifiedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string agent
    {
        get
        {
            return this.agentField;
        }
        set
        {
            this.agentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string etag
    {
        get
        {
            return this.etagField;
        }
        set
        {
            this.etagField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class mxfileDiagram
{

    private mxfileDiagramMxGraphModel mxGraphModelField;

    private string nameField;

    private string idField;

    /// <remarks/>
    public mxfileDiagramMxGraphModel mxGraphModel
    {
        get
        {
            return this.mxGraphModelField;
        }
        set
        {
            this.mxGraphModelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class mxfileDiagramMxGraphModel
{

    private mxfileDiagramMxGraphModelMxCell[] rootField;

    private ushort dxField;

    private ushort dyField;

    private byte gridField;

    private byte gridSizeField;

    private byte guidesField;

    private byte tooltipsField;

    private byte connectField;

    private byte arrowsField;

    private byte foldField;

    private byte pageField;

    private decimal pageScaleField;

    private ushort pageWidthField;

    private ushort pageHeightField;

    private string backgroundField;

    private byte mathField;

    private byte shadowField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("mxCell", IsNullable = false)]
    public mxfileDiagramMxGraphModelMxCell[] root
    {
        get
        {
            return this.rootField;
        }
        set
        {
            this.rootField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort dx
    {
        get
        {
            return this.dxField;
        }
        set
        {
            this.dxField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort dy
    {
        get
        {
            return this.dyField;
        }
        set
        {
            this.dyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte grid
    {
        get
        {
            return this.gridField;
        }
        set
        {
            this.gridField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte gridSize
    {
        get
        {
            return this.gridSizeField;
        }
        set
        {
            this.gridSizeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte guides
    {
        get
        {
            return this.guidesField;
        }
        set
        {
            this.guidesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte tooltips
    {
        get
        {
            return this.tooltipsField;
        }
        set
        {
            this.tooltipsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte connect
    {
        get
        {
            return this.connectField;
        }
        set
        {
            this.connectField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte arrows
    {
        get
        {
            return this.arrowsField;
        }
        set
        {
            this.arrowsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fold
    {
        get
        {
            return this.foldField;
        }
        set
        {
            this.foldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte page
    {
        get
        {
            return this.pageField;
        }
        set
        {
            this.pageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal pageScale
    {
        get
        {
            return this.pageScaleField;
        }
        set
        {
            this.pageScaleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort pageWidth
    {
        get
        {
            return this.pageWidthField;
        }
        set
        {
            this.pageWidthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort pageHeight
    {
        get
        {
            return this.pageHeightField;
        }
        set
        {
            this.pageHeightField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string background
    {
        get
        {
            return this.backgroundField;
        }
        set
        {
            this.backgroundField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte math
    {
        get
        {
            return this.mathField;
        }
        set
        {
            this.mathField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte shadow
    {
        get
        {
            return this.shadowField;
        }
        set
        {
            this.shadowField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class mxfileDiagramMxGraphModelMxCell
{

    private mxfileDiagramMxGraphModelMxCellMxGeometry mxGeometryField;

    private string idField;

    private string styleField;

    private string parentField;

    private string sourceField;

    private string targetField;

    private byte edgeField;

    private bool edgeFieldSpecified;

    private string valueField;

    private byte vertexField;

    private bool vertexFieldSpecified;

    private byte connectableField;

    private bool connectableFieldSpecified;

    /// <remarks/>
    public mxfileDiagramMxGraphModelMxCellMxGeometry mxGeometry
    {
        get
        {
            return this.mxGeometryField;
        }
        set
        {
            this.mxGeometryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string style
    {
        get
        {
            return this.styleField;
        }
        set
        {
            this.styleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string parent
    {
        get
        {
            return this.parentField;
        }
        set
        {
            this.parentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string source
    {
        get
        {
            return this.sourceField;
        }
        set
        {
            this.sourceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string target
    {
        get
        {
            return this.targetField;
        }
        set
        {
            this.targetField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte edge
    {
        get
        {
            return this.edgeField;
        }
        set
        {
            this.edgeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool edgeSpecified
    {
        get
        {
            return this.edgeFieldSpecified;
        }
        set
        {
            this.edgeFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte vertex
    {
        get
        {
            return this.vertexField;
        }
        set
        {
            this.vertexField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool vertexSpecified
    {
        get
        {
            return this.vertexFieldSpecified;
        }
        set
        {
            this.vertexFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte connectable
    {
        get
        {
            return this.connectableField;
        }
        set
        {
            this.connectableField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool connectableSpecified
    {
        get
        {
            return this.connectableFieldSpecified;
        }
        set
        {
            this.connectableFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class mxfileDiagramMxGraphModelMxCellMxGeometry
{

    private object[] itemsField;

    private byte relativeField;

    private bool relativeFieldSpecified;

    private string asField;

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    private decimal widthField;

    private bool widthFieldSpecified;

    private decimal heightField;

    private bool heightFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Array", typeof(mxfileDiagramMxGraphModelMxCellMxGeometryArray))]
    [System.Xml.Serialization.XmlElementAttribute("mxPoint", typeof(mxfileDiagramMxGraphModelMxCellMxGeometryMxPoint))]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte relative
    {
        get
        {
            return this.relativeField;
        }
        set
        {
            this.relativeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool relativeSpecified
    {
        get
        {
            return this.relativeFieldSpecified;
        }
        set
        {
            this.relativeFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string @as
    {
        get
        {
            return this.asField;
        }
        set
        {
            this.asField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool widthSpecified
    {
        get
        {
            return this.widthFieldSpecified;
        }
        set
        {
            this.widthFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool heightSpecified
    {
        get
        {
            return this.heightFieldSpecified;
        }
        set
        {
            this.heightFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class mxfileDiagramMxGraphModelMxCellMxGeometryArray
{

    private mxfileDiagramMxGraphModelMxCellMxGeometryArrayMxPoint[] mxPointField;

    private string asField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("mxPoint")]
    public mxfileDiagramMxGraphModelMxCellMxGeometryArrayMxPoint[] mxPoint
    {
        get
        {
            return this.mxPointField;
        }
        set
        {
            this.mxPointField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string @as
    {
        get
        {
            return this.asField;
        }
        set
        {
            this.asField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class mxfileDiagramMxGraphModelMxCellMxGeometryArrayMxPoint
{

    private ushort xField;

    private ushort yField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class mxfileDiagramMxGraphModelMxCellMxGeometryMxPoint
{

    private string asField;

    private decimal xField;

    private bool xFieldSpecified;

    private decimal yField;

    private bool yFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string @as
    {
        get
        {
            return this.asField;
        }
        set
        {
            this.asField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool xSpecified
    {
        get
        {
            return this.xFieldSpecified;
        }
        set
        {
            this.xFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ySpecified
    {
        get
        {
            return this.yFieldSpecified;
        }
        set
        {
            this.yFieldSpecified = value;
        }
    }
}

