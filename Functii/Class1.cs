using Proiect;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functii
{
    public class Class1
    {
        static public void Verificare_existenta()
        {
            using (Model1Container context = new Model1Container())
            {
                var querry = from photo in context.Media
                             select photo;
                foreach (var p in querry)
                {
                    if (File.Exists(p.Path))
                        p.Status = "1";
                    else
                        p.Status = "0";
                }
                context.SaveChanges();

            }

        }
        static public void Update_proprietati(string path, string coloana, string valoare)
        {
            int ok = 0;
            if (coloana == "Location")
            {
                ok = 1;
                using (Model1Container context = new Model1Container())
                {
                    var rezultat =
                    from poza in context.Media
                    where poza.Path == path
                    select poza;
                    foreach (var p in rezultat)
                    {
                        p.Location = valoare;
                    }
                    context.SaveChanges();
                }
                
            }

            if (coloana == "Event")
            {
                ok = 1;
                using (Model1Container context = new Model1Container())
                {
                    var rezultat =
                    from poza in context.Media
                    where poza.Path == path
                    select poza;
                    foreach (var p in rezultat)
                    {
                        p.Event = valoare;
                    }
                    context.SaveChanges();
                }

            }

            if (coloana == "Event")
            {
                ok = 1;
                using (Model1Container context = new Model1Container())
                {
                    var rezultat =
                    from poza in context.Media
                    where poza.Path == path
                    select poza;
                    foreach (var p in rezultat)
                    {
                        p.Event = valoare;
                    }
                    context.SaveChanges();
                }

            }

            if (coloana == "Scenery")
            {
                ok = 1;
                using (Model1Container context = new Model1Container())
                {
                    var rezultat =
                    from poza in context.Media
                    where poza.Path == path
                    select poza;
                    foreach (var p in rezultat)
                    {
                        p.Scenery = valoare;
                    }
                    context.SaveChanges();
                }

            }


            if (coloana == "Status")
            {
                ok = 1;
                using (Model1Container context = new Model1Container())
                {
                    var rezultat =
                    from poza in context.Media
                    where poza.Path == path
                    select poza;
                    foreach (var p in rezultat)
                    {
                        p.Status = valoare;
                    }
                    context.SaveChanges();
                }

            }
            if (ok == 0)
            {
                using (Model1Container context = new Model1Container())
                {
                    var rezultat =
                    from poza in context.Media
                    join din in context.Dinamice on poza.Id equals din.PhotoId
                    join pp in context.Proprietati on din.PropertiesId equals pp.Id
                    where pp.Name == coloana && poza.Path == path
                    select din;
                    foreach (var p in rezultat)
                    {
                        p.Data = valoare;
                    }
                    context.SaveChanges();
                }
            }

        }
        static public void stergere_poza(string name)
        {
            using (Model1Container context = new Model1Container())
            {
                var remove = (from photo in context.Media
                              where photo.Path == name
                              select photo).FirstOrDefault();
                int pozitie = remove.Id;

                var remove1 = (from per in context.Persoane
                               where per.PhotoId == pozitie
                               select per);

                var remove2 = (from din in context.Dinamice
                               where din.PhotoId == pozitie
                               select din);

                foreach(var item in remove1)
                {
                    context.Persoane.Remove(item);
                }

                foreach (var item in remove2)
                {
                    context.Dinamice.Remove(item);
                }

                if (remove != null)
                {
                    context.Media.Remove(remove);
                    context.SaveChanges();
                }
            }
        }
        static public void Tag(string path, string persoana)
        {
            using (Model1Container context = new Model1Container())
            {
                var rezultat= 
                (from poza in context.Media
                where poza.Path == path
                select poza.Id);
                var lista = rezultat.ToList();
                if (lista.Count() > 0)
                {


                    Person p = new Person()
                    {
                        PhotoId = lista[0],
                        Name = persoana

                    };
                    context.Persoane.Add(p);
                    context.SaveChanges();
                }

            }
        }
        static public void Add_Dinamic(string Nume)
        {
            using (Model1Container context = new Model1Container())
            {

             
                    Proprietate p = new Proprietate()
                    {
                        Name = Nume
                    };
                    context.Proprietati.Add(p);
                    context.SaveChanges();

            }
        }

        static public List<string> Afisare_persoane()
        {
            using (Model1Container context = new Model1Container())
            {
                var rezultat =
                from pers in context.Persoane
                select pers.Name;
                var lista = rezultat.ToList();
                var ceva = lista.Distinct();
                var final = ceva.ToList();
                return final;

            }
        }

        static public List<string> Afisare_Media()
        {
            using (Model1Container context = new Model1Container())
            {
                var rezultat =
                from photo in context.Media
                select photo.Path;
                var lista = rezultat.ToList();
                return lista;

            }
        }

        static public void Scriere_in_fisier(string path, string scris)
        {
            using (FileStream fs = File.Create(path))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(scris);
                fs.Write(info, 0, info.Length);
            }

        }
        static public IList<string> Afisare_rezultate(string coloana, string date)
        {
            if(coloana == "Location")
            {
                using (Model1Container context = new Model1Container())
                {
                    var rezultat =
                    from poza in context.Media
                    where poza.Location == date && poza.Status.Equals("1")
                    select poza.Path;
                    var lista = rezultat.ToList();
                    return lista;
                }
            }
            if (coloana == "Event")
            {
                using (Model1Container context = new Model1Container())
                {
                    var rezultat =
                    from poza in context.Media
                    where poza.Event == date && poza.Status.Equals("1")
                    select poza.Path;
                    var lista = rezultat.ToList();
                    return lista;
                }
            }
            if (coloana == "Status")
            {
                using (Model1Container context = new Model1Container())
                {
                    var rezultat =
                    from poza in context.Media
                    where poza.Status == date && poza.Status.Equals("1")
                    select poza.Path;
                    var lista = rezultat.ToList();
                    return lista;
                }
            }

            if (coloana == "Scenery")
            {
                using (Model1Container context = new Model1Container())
                {
                    var rezultat =
                    from poza in context.Media
                    where poza.Scenery == date && poza.Status.Equals("1")
                    select poza.Path;
                    var lista = rezultat.ToList();
                    return lista;
                }
            }

            if (coloana == "Persons")
            {
                using (Model1Container context = new Model1Container())
                {
                    var rezultat =
                    from pers in context.Persoane
                    join poza in context.Media on pers.PhotoId equals poza.Id
                    where pers.Name == date && poza.Status.Equals("1")
                    select poza.Path;
                    var lista = rezultat.ToList();
                    return lista;
                }
            }

            using (Model1Container context = new Model1Container())
            {
                    var rezultat =
                    from poza in context.Media
                    join din in context.Dinamice on poza.Id equals din.PhotoId
                    join pp in context.Proprietati on din.PropertiesId equals pp.Id
                    where pp.Name == coloana && din.Data == date && poza.Status.Equals("1")
                    select poza.Path;
                    var lista = rezultat.ToList();
                    return lista;

            }
        }
        static public IList<string> Initializare_proprietati()
        {
            using (Model1Container context = new Model1Container())
            {
                var querry = from prop in context.Proprietati
                             select prop.Name;
                var lista = querry.ToList();
                return lista;
            }
            
        }


        static public void Add_Media(string nume, string locatie, string path, string peisaj, string eveniment)
        {
            using (Model1Container context = new Model1Container())
            {

                    Photo p = new Photo()
                    {
                        Name = nume,
                        Location = locatie,
                        Path = path,
                        Status = "1",
                        Scenery = peisaj

                    };
                    p.Event = eveniment;
                    context.Media.Add(p);
                    context.SaveChanges();
                

            }
        }
    }
}
