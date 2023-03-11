using razorclasslib.Models;
using Razor.Templating.Core;

var customObject = new CustomObject()
{
	Name = "User",
	Fields = new List<Field>()
	{
		new Field()
		{
			FieldName = "Name",
			TypeName = "string",
		},
		new Field()
		{
			FieldName = "Surname",
			TypeName = "string",
		}
	}
};

var html = await RazorTemplateEngine.RenderAsync("/Views/Student.cshtml", customObject);
System.Console.WriteLine(html);