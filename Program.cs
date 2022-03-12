using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MedicalForms
{
    static class Program
    {
       public static void OpenCreateForm()
        {
            
            Application.Run(new CreatePatienForm()); ;
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                int index = 0;
                string line;
                using (StreamReader text = new StreamReader("input.txt"))
                {
                    while ((line = text.ReadLine()) != null)
                    {
                        List < string > baze= (line.Split((char)164)).ToList();
                        string diagnaz="";
                        using (StreamReader textdiag=new StreamReader(index.ToString() + "d.txt"))
                        {
                            while ((line = textdiag.ReadLine()) != null)
                            {
                                diagnaz += line + "\n";
                            }
                        }
                        string hisory = "";
                        using (StreamReader texthis = new StreamReader(index.ToString() + "h.txt"))
                        {
                            while ((line = texthis.ReadLine()) != null)
                            {
                                hisory += line + "\n";
                            }
                        }
                        List<string> time = (baze[2].Split(':')).ToList();
                        DateTime t = new DateTime(int.Parse(time[0]), int.Parse(time[1]), int.Parse(time[2]));
                        if (baze[3].Equals("муж"))
                        {
                            ListPactient.Pactients.Add(new Pactient(baze[0], baze[1], t, true, diagnaz,hisory,baze[4]));
                        }
                        else
                        {
                            ListPactient.Pactients.Add(new Pactient(baze[0], baze[1], t, false, diagnaz, hisory, baze[4]));
                        }
                        


                    }
                }
            }
            catch
            {

            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());



            using (StreamWriter text=new StreamWriter("input.txt"))
            {
                for (int i = 0; i < ListPactient.Pactients.Count; i++)
                {
                    if (ListPactient.Pactients[i].Sex)
                    {
                        text.WriteLine(ListPactient.Pactients[i].Name + (char)164 + ListPactient.Pactients[i].SecondName + (char)164 + ListPactient.Pactients[i].DateofBirth + (char)164 + "муж" + (char)164 + ListPactient.Pactients[i].PathPhoto);


                    }
                    else
                    {
                        text.WriteLine(ListPactient.Pactients[i].Name + (char)164 + ListPactient.Pactients[i].SecondName + (char)164 + ListPactient.Pactients[i].DateofBirth + (char)164 + "жен" + (char)164 + ListPactient.Pactients[i].PathPhoto);
                    }
                    using (StreamWriter texthis=new StreamWriter(ListPactient.Pactients[i].Id.ToString() + "d.txt"))
                    {
                        texthis.WriteLine(ListPactient.Pactients[i].Information);
                    }
                    using (StreamWriter texthis = new StreamWriter(ListPactient.Pactients[i].Id.ToString() + "h.txt"))
                    {
                        texthis.WriteLine(ListPactient.Pactients[i].History);
                    }

                }
            }
            

        }
    }
}
