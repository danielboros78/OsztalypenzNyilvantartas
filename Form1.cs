using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OsztalypenzNyilvantartas
{
  public partial class Form1 : Form
  {
    List<Osztalypenz> adatok = new List<Osztalypenz>();
    public Form1()
    {
      InitializeComponent();
      IdozitoElindit();
    }

    private void IdozitoElindit()
    {
      tIdozito.Start();
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      using (StreamReader be = new StreamReader("adatok.txt"))
      {
        while (!be.EndOfStream)
        {
          adatok.Add(new Osztalypenz(be.ReadLine()));
        }
      }
    }

    private void btnAllapotBetoltes_Click(object sender, EventArgs e)
    {
      AllapotBeolvasasa();
    }

    private void AllapotBeolvasasa()
    {
      lbAllapot.Items.Clear();
      int i = 1;
      int egyenleg = 0;
      foreach (Osztalypenz a in adatok)
      {
        if (a.FizetesTipus == "kifizetes")
        {
          lbAllapot.Items.Add($"{i}. tranzakció: {a.Osszeg} Ft-ot kifizettünk {a.Nev} részére. {a.Datum}");
          egyenleg -= a.Osszeg;
        }
        else
        {
          lbAllapot.Items.Add($"{i}. tranzakció: {a.Nev} befizetett {a.Osszeg} Ft-ot. {a.Datum}");
          egyenleg += a.Osszeg;
        }
        i++;
      }
      lblEgyenleg.Text = $"{egyenleg} Ft";
    }

    private void btnAllapotMentes_Click(object sender, EventArgs e)
    {

      if (rbBefizetes.Checked)
      {
        adatok.Add(new Osztalypenz(tbNev.Text, Convert.ToInt32(tbOsszeg.Text), "befizetes", dtpDatum.Value.ToString()));
      }
      else
      {
        adatok.Add(new Osztalypenz(tbNev.Text, Convert.ToInt32(tbOsszeg.Text), "kifizetes", dtpDatum.Value.ToString()));
      }

      using (StreamWriter ki = new StreamWriter("adatok.txt"))
      {
        foreach (var a in adatok)
        {
          ki.WriteLine($"{a.Nev};{a.Osszeg};{a.FizetesTipus};{a.Datum}");
        }
      }

      tbNev.Clear();
      tbOsszeg.Clear();
      AllapotBeolvasasa();
    }

    private void tIdozito_Tick(object sender, EventArgs e)
    {
      if (tbNev.Text == "" || tbOsszeg.Text == "")
      {
        btnAllapotMentes.Enabled = false;
      }
      else
      {
        btnAllapotMentes.Enabled = true;
      }
    }
  }
}
