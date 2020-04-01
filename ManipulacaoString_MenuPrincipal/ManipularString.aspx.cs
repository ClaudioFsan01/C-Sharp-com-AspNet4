using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ManipulacaoString_MenuPrincipal
{
    public partial class ManipularString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text.ToUpper(); // ToUpper() retorna uma copia da cadeia de caracteres em formato maiusculo
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text.ToLower(); // ToLower() retorna uma copia da cadeia de caracteres em formato minusculo
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           
                Label2Resultado.Text = Convert.ToString(TextBox1.Text.IndexOf("claudio"));
            //  IndexOf("claudio") retorna a posição index da 1° ocorrencia do nome claudio 
            // Convert.ToString converte o valor especificado em uma representação string
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
          if(TextBox1.Text.StartsWith("Jair"))
            {
                Response.Write("Começa com o nome do Presidente ");
            }
            else
            {
                Response.Write("Começa com um nome qualquer ");
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.EndsWith(".txt"))
            {
                Response.Write(" Documento é um Arquivo");
            }
            else
            {
                if (TextBox1.Text.EndsWith(".html"))
                {
                    Response.Write(" Documento é do tipo HTML");
                }
                else
                {
                    if (TextBox1.Text.EndsWith(".php"))
                    {
                        Response.Write(" Documento é do tipo php");
                    }
                    else
                    {
                        Response.Write(" Documento não identficado !");
                    }

                }

            }

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Label2Resultado.Text = TextBox1.Text.PadLeft(30, '$');
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Label2Resultado.Text = TextBox1.Text.PadRight(30, '*');
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Label2Resultado.Text = TextBox1.Text.Trim();
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Label2Resultado.Text = "Resultado" + TextBox1.Text; //.TrimStart();
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Label2Resultado.Text =  TextBox1.Text + "Final"; // .TrimEnd()
        }

        protected void Button12Split_Click(object sender, EventArgs e)
        {
            String[] array_texto = TextBox1.Text.Split(','); // Split separa a string em substring até a virgula


            for (int i=0; i < array_texto.Length; i++ )
            {
                Response.Write(" Posição : " + i + "=" + array_texto[i]);
            }


        }

        protected void Button12Join_Click(object sender, EventArgs e)
        {
            String[] nome = {"claudio","Felix","Santos"};

            String nomes = String.Join("-", nome);

            Label2Resultado.Text = nomes;


        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            //Response.Write(String.Format(" O conteudo do textbox é , (0)", TextBox1.Text));

            // Response.Write(String.Format(" Eu, (0), estou (1), entediado (2), (3)", TextBox1.Text));
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Write(String.Format(" Eu tenho (O:D)", 35));
        }
    }
}