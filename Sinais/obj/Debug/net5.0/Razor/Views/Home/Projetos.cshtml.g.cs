#pragma checksum "C:\Users\Remakker\Desktop\Sinais\Views\Home\Projetos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9071bcc431885d036a973b29b8b8d0863b3360d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Projetos), @"mvc.1.0.view", @"/Views/Home/Projetos.cshtml")]
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
#line 1 "C:\Users\Remakker\Desktop\Sinais\Views\_ViewImports.cshtml"
using AtividadeModulo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Remakker\Desktop\Sinais\Views\_ViewImports.cshtml"
using AtividadeModulo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9071bcc431885d036a973b29b8b8d0863b3360d9", @"/Views/Home/Projetos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"264c2145d8a876959308215e50450ae46fcc40ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Projetos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("section-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Remakker\Desktop\Sinais\Views\Home\Projetos.cshtml"
  
    ViewData["Title"] = "Projetos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9071bcc431885d036a973b29b8b8d0863b3360d93777", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""shortcut icon"" href=""./img/squad49.ico"" type=""image/x-icon"">
    <!--
    <link rel=""stylesheet"" href=""/css/style.css"">
    <link rel=""stylesheet"" href=""~/css/site.css"" />
    <link rel=""stylesheet"" href=""~/css/style1.css"" />
-->
    <!--Bootstrap CSS-->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
        integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.1.1/css/all.css""
        integrity=""sha384-O8whS3fhG2OnA5Kas0Y9l3cfpmYjapjI0E4theH4iuMD+pLhbf6JI0jIMfYcK3yZ"" crossorigin=""anonymous"">

    <!--Link Google Fonts-->
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gsta");
                WriteLiteral(@"tic.com"" crossorigin>
    <link
        href=""https://fonts.googleapis.com/css2?family=Libre+Baskerville:ital,wght@0,400;0,700;1,400&family=Playfair+Display:wght@500&display=swap""
        rel=""stylesheet"">

    <title>Sinais</title>
    <!--alterar nome do Projeto-->
    <style>
        body {
            font-family: 'Libre Baskerville', serif;
            font-size: 15px;
        }
    </style>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9071bcc431885d036a973b29b8b8d0863b3360d96269", async() => {
                WriteLiteral(@"

    <main style=""color:black""> 

        <section class=""py-5 text-center container"" style=""background-color: white;"">
          <div class=""row py-lg-5"">
            <div class=""col-lg-6 col-md-8 mx-auto"">
              <h1 class=""fw-light"">Projetos</h1>
              <p class=""lead text-muted"">Conheça abaixo algumas referências de projetos que podem ampliar seu conhecimento.</p>
              <!--<p>
                <a href=""#"" class=""btn btn-primary my-2"">Main call to action</a>
                <a href=""#"" class=""btn btn-secondary my-2"">Secondary action</a>
              </p>-->
            </div>
          </div>
        </section>
      
        <div class=""album py-5 bg-light"" id=""section-2"">
            <div class=""container"">
        
              <div class=""row row-cols-1 row-cols-sm-2 row-cols-md-3 g-3"">
                <div class=""col"">
                  <div class=""card shadow-sm"">
                    <!--<svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""");
                WriteLiteral(@"225"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Thumbnail"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c""/><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>-->
                    <img src=""/img/brasao.jpg"" width=""100%"" height=""225""");
                BeginWriteAttribute("alt", " alt=\"", 2946, "\"", 2952, 0);
                EndWriteAttribute();
                WriteLiteral(@">
        
                    <div class=""card-body"">
                      <p class=""card-text"">É instituída a Lei Brasileira de Inclusão da Pessoa com Deficiência (Estatuto da Pessoa com Deficiência), destinada a assegurar e a promover, em condições de igualdade, o exercício dos direitos e das liberdades fundamentais por pessoa com deficiência, visando à sua inclusão social e cidadania.</p>
                      <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                          <p>
                            <a href=""http://www.planalto.gov.br/ccivil_03/_ato2015-2018/2015/lei/l13146.htm"" class=""btn btn-sm btn-outline-secondary"">Veja Mais</a>
                          </p>
                        </div>
                        <small class=""text-muted"">Legislação</small>
                      </div>
                    </div>
                  </div>
                </div>
                <div class=""col"">
              ");
                WriteLiteral(@"    <div class=""card shadow-sm"">
                    <!--<svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Thumbnail"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c""/><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>-->
                    <img src=""/img/politize.png"" width=""100%"" height=""225""");
                BeginWriteAttribute("alt", " alt=\"", 4466, "\"", 4472, 0);
                EndWriteAttribute();
                WriteLiteral(@">
        
                    <div class=""card-body"">
                      <p class=""card-text"">A Lei Brasileira de Inclusão – LBI, também conhecida como Estatuto da Pessoa com Deficiência, é um conjunto de normas destinadas a assegurar e a promover, em igualdade de condições, o exercício dos direitos e liberdades fundamentais por pessoas com deficiência, visando à sua inclusão social e a cidadania.</p>
                      <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                          <p>
                            <a href=""https://www.politize.com.br/lei-brasileira-de-inclusao/?https://www.politize.com.br/&gclid=CjwKCAiArOqOBhBmEiwAsgeLmRBVY4HxG93qDkmSrE-j2xDVWkLvzRVo7GexSrMDG08St1iR_kV9XBoCNL0QAvD_BwE"" class=""btn btn-sm btn-outline-secondary"">Veja Mais</a>
                          </p>
                        </div>
                        <small class=""text-muted"">Legislação</small>
                      </div>
   ");
                WriteLiteral(@"                 </div>
                  </div>
                </div>
                <div class=""col"">
                  <div class=""card shadow-sm"">
                    <!--<svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Thumbnail"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c""/><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>-->
                    <img src=""/img/pcd.png""");
                BeginWriteAttribute("alt", " alt=\"", 6079, "\"", 6085, 0);
                EndWriteAttribute();
                WriteLiteral(@">
        
                    <div class=""card-body"">
                      <p class=""card-text"">Empregos para Surdos e Auditivos - Procurando Emprego? Acesse agora o Deficiente Online e cadastre seu Curriculo para que as melhores empresas possam encontrar você. Você também poderá se candidatar a vagas para Profissionais com Deficiencia que esteja no seu Perfil e tudo isso de graça.</p>
                      <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                          <p>
                            <a href=""https://www.deficienteonline.com.br/empregos-para-surdos-e-auditivos_pcdsc_369.html"" class=""btn btn-sm btn-outline-secondary"">Veja Mais</a>
                          </p>
                        </div>
                        <small class=""text-muted"">Projeto</small>
                      </div>
                    </div>
                  </div>
                </div>
                </div>
                </div");
                WriteLiteral(@">
                </div>
        
                <!--<div class=""col"">
                  <div class=""card shadow-sm"">
                    <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Thumbnail"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c""/><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
        
                    <div class=""card-body"">
                      <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                      <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                          <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                          <button type=""button"" class=");
                WriteLiteral(@"""btn btn-sm btn-outline-secondary"">Edit</button>
                        </div>
                        <small class=""text-muted"">9 mins</small>
                      </div>
                    </div>
                  </div>
                </div>
                <div class=""col"">
                  <div class=""card shadow-sm"">
                    <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Thumbnail"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c""/><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
        
                    <div class=""card-body"">
                      <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                      <div class=""d-flex justify-content-between align-items-ce");
                WriteLiteral(@"nter"">
                        <div class=""btn-group"">
                          <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                          <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Edit</button>
                        </div>
                        <small class=""text-muted"">9 mins</small>
                      </div>
                    </div>
                  </div>
                </div>
                <div class=""col"">
                  <div class=""card shadow-sm"">
                    <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Thumbnail"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c""/><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
        
                    <div class=""card-body"">
                      <p class=""card-text");
                WriteLiteral(@""">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                      <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                          <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                          <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Edit</button>
                        </div>
                        <small class=""text-muted"">9 mins</small>
                      </div>
                    </div>
                  </div>
                </div>
        
                <div class=""col"">
                  <div class=""card shadow-sm"">
                    <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Thumbnail"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholde");
                WriteLiteral(@"r</title><rect width=""100%"" height=""100%"" fill=""#55595c""/><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
        
                    <div class=""card-body"">
                      <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                      <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                          <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                          <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Edit</button>
                        </div>
                        <small class=""text-muted"">9 mins</small>
                      </div>
                    </div>
                  </div>
                </div>
                <div class=""col"">
                  <div class=""card shadow-sm"">
                    <svg class");
                WriteLiteral(@"=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Thumbnail"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c""/><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
        
                    <div class=""card-body"">
                      <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                      <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                          <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                          <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Edit</button>
                        </div>
                        <small class=""text-muted"">9 mins</small>
      ");
                WriteLiteral(@"                </div>
                    </div>
                  </div>
                </div>
                <div class=""col"">
                  <div class=""card shadow-sm"">
                    <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Thumbnail"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c""/><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
        
                    <div class=""card-body"">
                      <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                      <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                          <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</bu");
                WriteLiteral(@"tton>
                          <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Edit</button>
                        </div>
                        <small class=""text-muted"">9 mins</small>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>-->
      </main>   
      
      <br><br><br><br>
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
