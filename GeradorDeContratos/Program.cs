using System;
using System.IO;
using HtmlAgilityPack;
using SelectPdf;

namespace GeradorDeContratos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Caminho para os templates
            string templatePath1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "template_contrato1.html");
            string templatePath2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "template_contrato2.html");

            // Solicitar dados do Contrato 1
            Console.WriteLine("Digite os dados para o Contrato de Agenciamento (Contrato 1):");
            Console.Write("Local-Contrato: ");
            string localContrato1 = Console.ReadLine();
            Console.Write("Data-Contrato: ");
            string dataContrato1 = Console.ReadLine();
            Console.Write("Mês-Contrato: ");
            string mesContrato1 = Console.ReadLine();
            Console.Write("Nome-Modelo: ");
            string nomeModelo1 = Console.ReadLine();
            Console.Write("CPF-Modelo: ");
            string cpfModelo1 = Console.ReadLine();
            Console.Write("RG-Modelo: ");
            string rgModelo1 = Console.ReadLine();
            Console.Write("Endereço-Modelo: ");
            string enderecoModelo1 = Console.ReadLine();
            Console.Write("Número-Modelo: ");
            string numeroModelo1 = Console.ReadLine();
            Console.Write("Complemento-Modelo: ");
            string complementoModelo1 = Console.ReadLine();
            Console.Write("Bairro-Modelo: ");
            string bairroModelo1 = Console.ReadLine();
            Console.Write("Cidade-Modelo: ");
            string cidadeModelo1 = Console.ReadLine();
            Console.Write("CEP-Modelo: ");
            string cepModelo1 = Console.ReadLine();
            Console.Write("Telefone-Principal: ");
            string telefonePrincipal1 = Console.ReadLine();
            Console.Write("Telefone-Secundário: ");
            string telefoneSecundario1 = Console.ReadLine();
            Console.Write("Meses-Contrato: ");
            string mesesContrato1 = Console.ReadLine();

            // Ler e substituir os campos no template do Contrato 1
            string htmlContrato1 = File.ReadAllText(templatePath1);
            htmlContrato1 = htmlContrato1
                .Replace("{Local-Contrato}", localContrato1)
                .Replace("{Data-Contrato}", dataContrato1)
                .Replace("{Mes-Contrato}", mesContrato1)
                .Replace("{Nome-Modelo}", nomeModelo1)
                .Replace("{CPF-Modelo}", cpfModelo1)
                .Replace("{RG-Modelo}", rgModelo1)
                .Replace("{Endereço-Modelo}", enderecoModelo1)
                .Replace("{Numero-Modelo}", numeroModelo1)
                .Replace("{Complemento-Modelo}", complementoModelo1)
                .Replace("{Bairro-Modelo}", bairroModelo1)
                .Replace("{Cidade-Modelo}", cidadeModelo1)
                .Replace("{CEP-Modelo}", cepModelo1)
                .Replace("{Telefone-Principal}", telefonePrincipal1)
                .Replace("{Telefone-Secundario}", telefoneSecundario1)
                .Replace("{Meses-Contrato}", mesesContrato1);

            // Gerar PDF do Contrato 1
            GerarPdf(htmlContrato1, $"{nomeModelo1}_{cpfModelo1}_contrato1.pdf");

            Console.WriteLine("Contrato 1 gerado com sucesso!");

            // Solicitar dados do Contrato 2
            Console.WriteLine("Digite os dados para o Contrato de Produção Fotográfica (Contrato 2):");
            Console.Write("Local-Contrato: ");
            string localContrato2 = Console.ReadLine();
            Console.Write("Data-Contrato: ");
            string dataContrato2 = Console.ReadLine();
            Console.Write("Mês-Contrato: ");
            string mesContrato2 = Console.ReadLine();
            Console.Write("Nome-Modelo: ");
            string nomeModelo2 = Console.ReadLine();
            Console.Write("CPF-Modelo: ");
            string cpfModelo2 = Console.ReadLine();
            Console.Write("RG-Modelo: ");
            string rgModelo2 = Console.ReadLine();
            Console.Write("Endereço-Modelo: ");
            string enderecoModelo2 = Console.ReadLine();
            Console.Write("Número-Modelo: ");
            string numeroModelo2 = Console.ReadLine();
            Console.Write("Complemento-Modelo: ");
            string complementoModelo2 = Console.ReadLine();
            Console.Write("Bairro-Modelo: ");
            string bairroModelo2 = Console.ReadLine();
            Console.Write("Cidade-Modelo: ");
            string cidadeModelo2 = Console.ReadLine();
            Console.Write("CEP-Modelo: ");
            string cepModelo2 = Console.ReadLine();
            Console.Write("Telefone-Principal: ");
            string telefonePrincipal2 = Console.ReadLine();
            Console.Write("Telefone-Secundário: ");
            string telefoneSecundario2 = Console.ReadLine();
            Console.Write("Valor-Contrato: ");
            string valorContrato2 = Console.ReadLine();

            // Ler e substituir os campos no template do Contrato 2
            string htmlContrato2 = File.ReadAllText(templatePath2);
            htmlContrato2 = htmlContrato2
                .Replace("{Local-Contrato}", localContrato2)
                .Replace("{Data-Contrato}", dataContrato2)
                .Replace("{Mes-Contrato}", mesContrato2)
                .Replace("{Nome-Modelo}", nomeModelo2)
                .Replace("{CPF-Modelo}", cpfModelo2)
                .Replace("{RG-Modelo}", rgModelo2)
                .Replace("{Endereço-Modelo}", enderecoModelo2)
                .Replace("{Numero-Modelo}", numeroModelo2)
                .Replace("{Complemento-Modelo}", complementoModelo2)
                .Replace("{Bairro-Modelo}", bairroModelo2)
                .Replace("{Cidade-Modelo}", cidadeModelo2)
                .Replace("{CEP-Modelo}", cepModelo2)
                .Replace("{Telefone-Principal}", telefonePrincipal2)
                .Replace("{Telefone-Secundario}", telefoneSecundario2)
                .Replace("{Valor-Contrato}", valorContrato2);

            // Gerar PDF do Contrato 2
            GerarPdf(htmlContrato2, $"{nomeModelo2}_{cpfModelo2}_contrato2.pdf");

            Console.WriteLine("Contrato 2 gerado com sucesso!");
        }

        static void GerarPdf(string html, string fileName)
        {
            HtmlToPdf converter = new HtmlToPdf();
            PdfDocument doc = converter.ConvertHtmlString(html);
            string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
            doc.Save(outputPath);
            doc.Close();
        }
    }
}