using TypeGen.Core.SpecGeneration;
namespace Common.Model;

public class TypescriptExportSpec : GenerationSpec
{
  public TypescriptExportSpec()
  {
    AddInterface<IHasImage>()
      .Member("ImageId").Null().DefaultValue("null")
      .Member("ImageUrl").Null().DefaultValue("null");

    AddClass<PageDetail>();
    AddClass<PageResult<Object>>()
      .Member("Results").DefaultValue("[]");

    AddClass<QueryValue>();
    AddClass<PageQuery>()
      .Member("PageDetail").DefaultValue("new PageDetail()")
      .Member("Query").DefaultValue("[]");
  }
}
