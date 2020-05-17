namespace LibreriaComponenti.Models
{
    public class GridModel
    {
        public GridColumn[] Columns { get; set; }
        public object[] Rows { get; set; }
        public bool UseAnnotations { get; set; } 
    }

    public class GridColumn
    {
        public string Caption { get; set; }
        public string Format { get; set; }
    }
}