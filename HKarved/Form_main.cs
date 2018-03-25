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


namespace HKarved
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void btn_avahinnakiri_Click(object sender, EventArgs e)
        {
            string hkfile = "";
            if (openFileHK.ShowDialog() == DialogResult.OK)
            {
                hkfile = openFileHK.FileName;
                dsHK.HKhinnakiri.Clear();
                // MessageBox.Show(hkfile);
                System.IO.StreamReader myFile = new System.IO.StreamReader(hkfile, Encoding.GetEncoding(1252));
                string sisu = myFile.ReadToEnd();
                myFile.Close();
                string[] lines = sisu.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string line in lines)
                {
                    string[] col = line.Split(';');
                    if (col.Count() > 3)
                    {
                        DataSetHK.HKhinnakiriRow nr = dsHK.HKhinnakiri.NewHKhinnakiriRow();
                        decimal dv = 0;
                        DateTime dt;
                        nr.KOOD = col[0];
                        nr.NIMI = col[1];
                        decimal.TryParse(col[2], result: out dv);
                        nr.HIND = dv;
                        dt = DateTime.Today.AddYears(-10);
                        DateTime.TryParse(col[4], out dt);
                        nr.AKPV = dt;
                        
                        if (!DateTime.TryParse(col[5], out dt))
                        {
                            dt = DateTime.Today.AddYears(10);
                        }
                        nr.LKPV = dt;
                        if (nr.HIND != 0 && nr.AKPV<DateTime.Today && nr.LKPV>DateTime.Today)
                        {
                            dsHK.HKhinnakiri.AddHKhinnakiriRow(nr);
                        }
                    }
                }



            }
        }

        private void btn_avaarved_Click(object sender, EventArgs e)
        {
            if (openFile_arved.ShowDialog() == DialogResult.OK)
            {
                System.IFormatProvider cultureUS =
                   new System.Globalization.CultureInfo("en-US");
                dsHK.ARVED.Clear();
                // MessageBox.Show(hkfile);
                System.IO.StreamReader myFile = new System.IO.StreamReader(openFile_arved.FileName,true);
                string sisu = myFile.ReadToEnd();
                myFile.Close();
                dsHK.ARVED.Clear();
                string[] lines = sisu.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string line in lines)
                {
                    DataSetHK.ARVEDRow ar = dsHK.ARVED.NewARVEDRow();
                    string[] col = line.Split('\t');
                    if (col.Count() == 10)
                    {
                        int iv = 0; decimal dv = 0;
                        try
                        {
                            int.TryParse(col[0], out iv);
                            ar.LEHTID = iv;
                            int.TryParse(col[1], out iv);
                            ar.JRK = iv;
                            ar.ERIALAKOOD = col[2];
                            ar.HKKOOD = col[3];
                            decimal.TryParse(col[4], System.Globalization.NumberStyles.AllowDecimalPoint, cultureUS, out dv);
                            ar.KOGUS = dv;
                            decimal.TryParse(col[5], System.Globalization.NumberStyles.AllowDecimalPoint, cultureUS, out dv);
                            ar.KOEFITSENT1 = dv;
                            decimal.TryParse(col[6], System.Globalization.NumberStyles.AllowDecimalPoint, cultureUS, out dv);
                            ar.HIND = dv;
                            ar.KPV = col[7];
                            ar.TYHI = col[8];
                            decimal.TryParse(col[9], System.Globalization.NumberStyles.AllowDecimalPoint, cultureUS, out dv);
                            ar.KOEFITSENT2 = dv;



                            if (ar.LEHTID > 0)
                            {
                                dsHK.ARVED.AddARVEDRow(ar);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }


            }
        }

        private void btn_avalehed_Click(object sender, EventArgs e)
        {

            if (openFile_lehed.ShowDialog() == DialogResult.OK)
            {
                System.IFormatProvider cultureUS =
                   new System.Globalization.CultureInfo("en-US");
                
                // MessageBox.Show(hkfile);
                System.IO.StreamReader myFile = new System.IO.StreamReader(openFile_lehed.FileName,Encoding.GetEncoding(1252));
                string sisu = myFile.ReadToEnd();
                myFile.Close();
                dsHK.LEHED.Clear();
                string[] lines = sisu.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string line in lines)
                {
                    DataSetHK.LEHEDRow lr = dsHK.LEHED.NewLEHEDRow();
                    string[] col = line.Split('\t');
                    if (col.Count()>20)
                    {
                        int iv = 0; decimal dv = 0;
                        try
                        {
                            int.TryParse(col[0], out iv);
                            lr.LEHTID = iv;
                            int.TryParse(col[1], out iv);
                          
                            decimal.TryParse(col[26], System.Globalization.NumberStyles.AllowDecimalPoint, cultureUS, out dv);
                            lr.SUMMA = dv;
                            string info = "";
                            for (int i=1; i < 26; i++)
                            {
                                info = info + col[i]+';';
                            }
                            lr.INFO = info;

                            string info2 = "";
                            for (int i = 27; i < col.Count(); i++)
                            {
                                
                                info2 = info2 + col[i];
                                if (i < col.Count() - 1)
                                {
                                    info2 += ';';
                                }
                            }
                            lr.INFO2 = info2;

                            if (lr.LEHTID > 0)
                            {
                                dsHK.LEHED.AddLEHEDRow(lr);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }


            }
        }

        private void btnTootle_Click(object sender, EventArgs e)
        {
            foreach( DataSetHK.ARVEDRow ar in dsHK.ARVED)
            {
                decimal hkhind = 0;
                hkhind = dsHK.HKhinnakiri.First(uu => uu.KOOD == ar.HKKOOD).HIND*ar.KOGUS;
                if (ar.HIND != hkhind)
                {
                    ar.SetColumnError(6, string.Format("VANA HIND {0}",ar.HIND));
                    ar.HIND = hkhind;
                    
                }

            }
            foreach(DataSetHK.LEHEDRow lr in dsHK.LEHED)
            {
                decimal summa = 0;
                summa = dsHK.ARVED.Where(ar => ar.LEHTID == lr.LEHTID).Select(x => x.KOEFITSENT1 * x.KOEFITSENT2 * x.HIND).Sum();
                if(lr.SUMMA != summa)
                {
                    lr.SetColumnError(2,string.Format( "VANA SUMMA {0} ",lr.SUMMA));
                    lr.SUMMA = summa;
                }
            }
        }

        
        private void btn_kirjutafailid_Click(object sender, EventArgs e)
        {
            //vanadfailid nimetame ringi
            try
            {
                System.IO.File.Move(openFile_arved.FileName, System.IO.Path.ChangeExtension(openFile_arved.FileName, ".old"));
                System.IO.File.Move(openFile_lehed.FileName, System.IO.Path.ChangeExtension(openFile_lehed.FileName, ".old"));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                // arved.dat
                using (StreamWriter sw = File.CreateText(openFile_arved.FileName))
                {
                    foreach(DataSetHK.ARVEDRow ar in dsHK.ARVED)
                    {
                        //string line = "";

                        sw.WriteLine(string.Join("\t", ar.ItemArray.Select(it => it.ToString())).Replace(',','.'));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                // lehed.dat
                using (StreamWriter lw = File.CreateText(openFile_lehed.FileName))
                {
                    foreach (DataSetHK.LEHEDRow lr in dsHK.LEHED)
                    {
                        string line = lr.LEHTID.ToString() + "\t";
                        line = line + lr.INFO.Replace(';', '\t');
                        line = line + lr.SUMMA.ToString().Replace(',','.');
                        line = line +"\t"+ lr.INFO2.Replace(';', '\t');


                        lw.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
