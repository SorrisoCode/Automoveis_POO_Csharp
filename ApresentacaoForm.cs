using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Http.Headers;

namespace POO
{
    internal class ApresentacaoForm : Form
    {
        Label titulo01 = new Label();
        Label titulo02 = new Label();
        Label titulo03 = new Label();

        Automovel obj01 = new Automovel("Fiat", "Uno", "180km/h", 2020, "img.png");

        Label txtMarca = new Label();
        Label txtModelo = new Label();
        Label txtVelocidade = new Label();
        Label txtAno = new Label();
        Label txtImagem = new Label();
        Label txtTipo = new Label();
        Label txtFrear = new Label();

        Button btobj01 = new Button();
        Button btobj02 = new Button();
        Button btobj03 = new Button();
        Button btHeranca = new Button();

        PictureBox img = new PictureBox();


        public ApresentacaoForm()
        {
            this.Text = "Apresentação";
            this.Size = new Size(600, 600);

            titulo01.Text = "Botões com descrições dos veículos";
            titulo01.Font = new Font("Arial", 16);
            titulo01.AutoSize = true;
            titulo01.Location = new Point(100, 100);

            txtFrear.AutoSize = true;
            txtTipo.AutoSize = true;

            btobj01.Text = "Uno";
            btobj01.Location = new Point(50, 50);
            btobj01.Click += clicar;
            btobj02.Click += clicar2;
            btobj02.Text = "Opala";
            btobj02.Location = new Point(150, 50);

            btobj03.Click += clicar3;
            btobj03.Text = "Camaro";
            btobj03.Location = new Point(250, 50);


            titulo02.Location = new Point(105, 105);
            titulo02.AutoSize = true;
            titulo02.Text = obj01.Marca;

            titulo03.Location = new Point(110, 110);
            titulo03.AutoSize = true;
            titulo03.Text = obj01.Marca;

            btHeranca.Text = "Herança";
            btHeranca.Location = new Point(350, 50);
            btHeranca.Click += clicarHeranca;


            Control[] elementos = { titulo01, titulo02, txtMarca, btobj01, txtModelo, txtAno, txtVelocidade, txtImagem, btobj02, btobj03, btHeranca, txtTipo, txtFrear };
            this.Controls.AddRange(elementos);

            img.Location = new Point(100, 220);
            img.Size = new Size(150, 150);
            img.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Controls.Add(img);
        }

        private void clicar(object sender, EventArgs e)
        {
            //MessageBox.Show("Método de Evento");
            // usando propriedade (não usa mais Set/Get)
            obj01.Marca = "Fiat";
            obj01.Modelo = "Uno";
            obj01.Ano = 2020;
            obj01.Velocidade = "180 km/h";

            txtMarca.Text = "Marca: " + obj01.Marca;
            txtModelo.Text = "Modelo: " + obj01.Modelo;
            txtAno.Text = "Ano: " + obj01.Ano;
            txtVelocidade.Text = "Velocidade: " + obj01.Velocidade;

            txtMarca.Location = new Point(100, 140);
            txtModelo.Location = new Point(100, 170);
            txtAno.Location = new Point(100, 200);
            txtVelocidade.Location = new Point(100, 230);
            txtMarca.AutoSize = true;
            txtModelo.AutoSize = true;
            txtAno.AutoSize = true;
            txtVelocidade.AutoSize = true;

            txtVelocidade.Text = "Velocidade: " + obj01.Velocidade + "\n" + obj01.Acelerar("180");

            img.Image = Image.FromFile("C:\\Users\\LabInfo\\source\\repos\\Automoveis_POO_Csharp\\img\\fiat.jpg");
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            this.img.Location = new Point(100, 290);
            img.Width = 200;
            img.Height = 150;
        }
        private void clicar2(object sender, EventArgs e)
        {
            obj01.Marca = "Chevrolet";
            obj01.Modelo = "Opala";
            obj01.Ano = 1980;
            obj01.Velocidade = "170 km/h";

            txtMarca.Text = "Marca: " + obj01.Marca;
            txtModelo.Text = "Modelo: " + obj01.Modelo;
            txtAno.Text = "Ano: " + obj01.Ano;
            txtVelocidade.Text = "Velocidade: " + obj01.Velocidade;

            txtMarca.Location = new Point(100, 140);
            txtModelo.Location = new Point(100, 170);
            txtAno.Location = new Point(100, 200);
            txtVelocidade.Location = new Point(100, 230);
            txtMarca.AutoSize = true;
            txtModelo.AutoSize = true;
            txtAno.AutoSize = true;
            txtVelocidade.AutoSize = true;

            txtVelocidade.Text = "Velocidade: " + obj01.Velocidade + "\n" + obj01.Acelerar("170");

            img.Image = Image.FromFile("C:\\Users\\LabInfo\\source\\repos\\Automoveis_POO_Csharp\\img\\opala.jpg");
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            this.img.Location = new Point(100, 290);
            img.Width = 200;
            img.Height = 150;
        }
        private void clicar3(object sender, EventArgs e)
        {
            obj01.Marca = "Chevrolet";
            obj01.Modelo = "Camaro";
            obj01.Ano = 2007;
            obj01.Velocidade = "250 km/h";

            txtMarca.Text = "Marca: " + obj01.Marca;
            txtModelo.Text = "Modelo: " + obj01.Modelo;
            txtAno.Text = "Ano: " + obj01.Ano;
            txtVelocidade.Text = "Velocidade: " + obj01.Velocidade;

            txtMarca.Location = new Point(100, 140);
            txtModelo.Location = new Point(100, 170);
            txtAno.Location = new Point(100, 200);
            txtVelocidade.Location = new Point(100, 230);
            txtMarca.AutoSize = true;
            txtModelo.AutoSize = true;
            txtAno.AutoSize = true;
            txtVelocidade.AutoSize = true;

            txtVelocidade.Text = "Velocidade: " + obj01.Velocidade + "\n" + obj01.Acelerar("250");

            img.Image = Image.FromFile("C:\\Users\\LabInfo\\source\\repos\\Automoveis_POO_Csharp\\img\\camaro.jpg");//corrigir caminho;
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            this.img.Location = new Point(100, 290);
            img.Width = 200;
            img.Height = 150;
        }

        private void clicarHeranca(object sender, EventArgs e)
        {
            Carro Obj01Carro = new Carro("CHEVETTE", "SUV");

            txtMarca.Text = "Marca: " + Obj01Carro.Marca;
            txtTipo.Text = "Tipo: " + Obj01Carro.Modelo;

            txtVelocidade.Text = "Velocidade: 200 km/h" + "\n" + Obj01Carro.Acelerar("200");

            txtFrear.Text = Obj01Carro.Frear();
            txtAno.Text = "Ano: 1970";
            txtMarca.Location = new Point(350, 140);
            txtTipo.Location = new Point(350, 170);
            txtVelocidade.Location = new Point(350, 200);
            txtFrear.Location = new Point(350, 250);
            txtAno.Location = new Point(350, 230);
            txtAno.AutoSize = true;

            txtMarca.AutoSize = true;
            txtTipo.AutoSize = true;
            txtVelocidade.AutoSize = true;
            txtFrear.AutoSize = true;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ApresentacaoForm
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "ApresentacaoForm";
            this.Load += new System.EventHandler(this.ApresentacaoForm_Load);
            this.ResumeLayout(false);

        }

        private void ApresentacaoForm_Load(object sender, EventArgs e)
        {

        }
    }
}