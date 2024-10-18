/*
 * Criado por SharpDevelop.
 * Usuário: COOLER
 * Data: 17/05/2021
 * Hora: 19:23
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo_de_dados
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		Random rnd = new Random();
		/*void Button1Click(object sender, EventArgs e)
		{
			int n = rnd.Next(1,7);
			button1.BackgroundImage = Image.FromFile("dado"+n+".png");*/
		void Button7Click(object sender, EventArgs e)
		{
			int n1 = rnd.Next(1,7);
			int n2 = rnd.Next(1,7);
			int n3 = rnd.Next(1,7);
			int n4 = rnd.Next(1,7);
			int n5 = rnd.Next(1,7);
	
			button1.BackgroundImage = Image.FromFile("dado"+n1+".png");
			button2.BackgroundImage = Image.FromFile("dado"+n2+".png");
			button3.BackgroundImage = Image.FromFile("dado"+n3+".png");
			button4.BackgroundImage = Image.FromFile("dado"+n4+".png");
			button5.BackgroundImage = Image.FromFile("dado"+n5+".png");
			
			string texto="";
			
			if(n1==n2 && n1==n3 && n1==n4 && n1==n5)
			{
				texto="Quina";
				MessageBox.Show("Parabéns, conseguiu uma quina! de "+n1);
			}else if((n1==n2 && n1==n3 && n1==n4) ||
				(n1==n2 && n1==n3 && n1==n5) ||
				(n1==n2 && n1==n4 && n1==n5) ||
				(n1==n3 && n1==n4 && n1==n5) ||
				(n2==n3 && n2==n4 && n2==n5)){
				texto="Quadra";
			}else if((n1==n2 && n1==n3) ||
			         (n1==n2 && n1==n4) ||
			         (n1==n2 && n1==n5) ||
			         (n1==n3 && n1==n4) ||
			         (n1==n3 && n1==n5) ||
			         (n1==n4 && n4==n5) ||
			         (n2==n3 && n2==n4) ||
			         (n2==n3 && n2==n5) ||
			         (n3==n5 && n3==n5)){
				texto="Trinca";
			}
			label1.Text = texto;
		//void Button4Click(object sender, EventArgs e){}
		}
		void Button6Click(object sender, EventArgs e)
		{
			button6.Enabled = true;
		}
	}
}