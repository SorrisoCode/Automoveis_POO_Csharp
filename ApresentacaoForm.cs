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
        Label titulo04 = new Label();   
        Label titulo05 = new Label();

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
        Button btobj04 = new Button();  
        Button btHeranca = new Button();
        Button btCorvette = new Button();
        Button btFusca = new Button();

        PictureBox img = new PictureBox();

        public ApresentacaoForm()
        {
            this.Text = "Apresentação";
            this.Size = new Size(950, 700);
            titulo01.Text = "Botões com descrições dos veículos";
            titulo01.Font = new Font("Arial", 16);
            titulo01.AutoSize = true;

            // força o cálculo do tamanho antes de centralizar
            this.Controls.Add(titulo01);

            titulo01.Left = (this.ClientSize.Width - titulo01.Width) / 2;
            titulo01.Top = 20;

            txtFrear.AutoSize = true;
            txtTipo.AutoSize = true;

            btobj01.Text = "Uno";
            btobj01.Location = new Point(50, 80);
            btobj01.Click += clicar;

            btobj02.Text = "Opala";
            btobj02.Location = new Point(150, 80);
            btobj02.Click += clicar2;

            btobj03.Text = "Camaro";
            btobj03.Location = new Point(250, 80);
            btobj03.Click += clicar3;

            btCorvette.Text = "Corvette";
            btCorvette.Location = new Point(350, 80);
            btCorvette.Click += clicar4;

            btFusca.Text = "Fusca";
            btFusca.Location = new Point(450, 80);
            btFusca.Click += clicar5;

            btHeranca.Text = "Herança";
            btHeranca.Location = new Point(550, 80);
            btHeranca.Click += clicarHeranca;

            titulo02.Location = new Point(105, 105);
            titulo02.AutoSize = true;

            titulo03.Location = new Point(110, 110);
            titulo03.AutoSize = true;

            Control[] elementos =
            {
                titulo01,
                titulo02,
                txtMarca,
                btobj01,
                txtModelo,
                txtAno,
                txtVelocidade,
                txtImagem,
                btobj02,
                btobj03,
                btCorvette,
                btHeranca,
                txtTipo,
                txtFrear,
                btFusca
            };

            this.Controls.AddRange(elementos);
            CentralizarBotoes();
            this.Resize += (s, e) => CentralizarBotoes();

            img.Location = new Point(100, 220);
            img.Width = 150;
            img.Height = 150;
            img.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Controls.Add(img);

            foreach (Control c in this.Controls)
            {
                if (c is Button b)
                {
                    b.TabStop = false;
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderSize = 1;

                    b.BackColor = Color.LightGray;
                    b.ForeColor = Color.Black;

                    b.FlatAppearance.MouseOverBackColor = Color.DarkGray;
                    b.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                }
            }
        }

        private void CentralizarBotoes()
        {
            Button[] botoes =
            {
                btobj01, btobj02, btobj03,
                btCorvette, btFusca, btHeranca
            };

            int larguraBotao = 100;
            int espacamento = 15;

            int totalLargura = (botoes.Length * larguraBotao) + ((botoes.Length - 1) * espacamento);

            int startX = (this.ClientSize.Width - totalLargura) / 2;
            int y = 80;

            for (int i = 0; i < botoes.Length; i++)
            {
                botoes[i].Location = new Point(
                    startX + i * (larguraBotao + espacamento),
                    y
                );
            }
        }

        private void clicar(object sender, EventArgs e)
        {
            obj01.Marca = "Fiat";
            obj01.Modelo = "Uno";
            obj01.Ano = 2020;
            obj01.Velocidade = "180 km/h";

            txtMarca.Text = "Marca: " + obj01.Marca;
            txtModelo.Text = "Modelo: " + obj01.Modelo;
            txtAno.Text = "Ano: " + obj01.Ano;
            txtVelocidade.Text = "Velocidade: " + obj01.Velocidade + "\n" + obj01.Acelerar("180");

            txtMarca.Location = new Point(100, 140);
            txtModelo.Location = new Point(100, 170);
            txtAno.Location = new Point(100, 200);
            txtVelocidade.Location = new Point(100, 230);

            txtMarca.AutoSize = true;
            txtModelo.AutoSize = true;
            txtAno.AutoSize = true;
            txtVelocidade.AutoSize = true;

            img.Image = Image.FromFile("C:\\Users\\LabInfo\\source\\repos\\Automoveis_POO_Csharp\\img\\fiat.jpg");
            img.Location = new Point(100, 290);
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
            txtVelocidade.Text = "Velocidade: " + obj01.Velocidade + "\n" + obj01.Acelerar("170");

            txtMarca.Location = new Point(100, 140);
            txtModelo.Location = new Point(100, 170);
            txtAno.Location = new Point(100, 200);
            txtVelocidade.Location = new Point(100, 230);

            txtMarca.AutoSize = true;
            txtModelo.AutoSize = true;
            txtAno.AutoSize = true;
            txtVelocidade.AutoSize = true;

            img.Image = Image.FromFile("C:\\Users\\LabInfo\\source\\repos\\Automoveis_POO_Csharp\\img\\opala.jpg");
            img.Location = new Point(100, 290);
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
            txtVelocidade.Text = "Velocidade: " + obj01.Velocidade + "\n" + obj01.Acelerar("250");

            txtMarca.Location = new Point(100, 140);
            txtModelo.Location = new Point(100, 170);
            txtAno.Location = new Point(100, 200);
            txtVelocidade.Location = new Point(100, 230);

            txtMarca.AutoSize = true;
            txtModelo.AutoSize = true;
            txtAno.AutoSize = true;
            txtVelocidade.AutoSize = true;

            img.Image = Image.FromFile("C:\\Users\\LabInfo\\source\\repos\\Automoveis_POO_Csharp\\img\\camaro.jpg");
            img.Location = new Point(100, 290);
            img.Width = 200;
            img.Height = 150;
        }

        private void clicar4(object sender, EventArgs e)
        {
            obj01.Marca = "Chevrolet";
            obj01.Modelo = "Corvette C6";
            obj01.Ano = 2008;
            obj01.Velocidade = "300 km/h";

            txtMarca.Text = "Marca: " + obj01.Marca;
            txtModelo.Text = "Modelo: " + obj01.Modelo;
            txtAno.Text = "Ano: " + obj01.Ano;
            txtVelocidade.Text = "Velocidade: " + obj01.Velocidade + "\n" + obj01.Acelerar("300");

            txtMarca.Location = new Point(100, 140);
            txtModelo.Location = new Point(100, 170);
            txtAno.Location = new Point(100, 200);
            txtVelocidade.Location = new Point(100, 230);

            txtMarca.AutoSize = true;
            txtModelo.AutoSize = true;
            txtAno.AutoSize = true;
            txtVelocidade.AutoSize = true;

            img.Image = Image.FromFile("C:\\Users\\LabInfo\\source\\repos\\Automoveis_POO_Csharp\\img\\corvette.jpg");
            img.Location = new Point(100, 290);
            img.Width = 200;
            img.Height = 150;
        }

        private void clicar5(object sender, EventArgs e)
        {
            obj01.Marca = "Volkswagen";
            obj01.Modelo = "Beetle";
            obj01.Ano = 1953;
            obj01.Velocidade = "100 km/h";

            txtMarca.Text = "Marca: " + obj01.Marca;
            txtModelo.Text = "Modelo: " + obj01.Modelo;
            txtAno.Text = "Ano: " + obj01.Ano;
            txtVelocidade.Text = "Velocidade: " + obj01.Velocidade + "\n" + obj01.Acelerar("100");

            txtMarca.Location = new Point(100, 140);
            txtModelo.Location = new Point(100, 170);
            txtAno.Location = new Point(100, 200);
            txtVelocidade.Location = new Point(100, 230);

            txtMarca.AutoSize = true;
            txtModelo.AutoSize = true;
            txtAno.AutoSize = true;
            txtVelocidade.AutoSize = true;

            img.Image = Image.FromFile("C:\\Users\\LabInfo\\source\\repos\\Automoveis_POO_Csharp\\img\\fusca.jpg");
            img.Location = new Point(100, 290);
            img.Width = 200;
            img.Height = 150;
        }

        private void clicarHeranca(object sender, EventArgs e)
        {
            Carro Obj01Carro = new Carro("CHEVETTE", "SUV");

            txtMarca.Text = "Marca: " + Obj01Carro.Marca;
            txtTipo.Text = "Tipo: " + Obj01Carro.Modelo;

            txtVelocidade.Text = "Velocidade: 200 km/h\n" + Obj01Carro.Acelerar("200");

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
            this.ClientSize = new System.Drawing.Size(320, 363);
            this.Name = "ApresentacaoForm";
            this.Load += new System.EventHandler(this.ApresentacaoForm_Load);
            this.ResumeLayout(false);

        }

        private void ApresentacaoForm_Load(object sender, EventArgs e)
        {

        }
    }
}