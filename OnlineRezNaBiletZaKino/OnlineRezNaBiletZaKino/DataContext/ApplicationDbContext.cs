using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Npgsql;
using OnlineRezNaBiletZaKino.Models;

namespace OnlineRezNaBiletZaKino.DataContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base(nameOrConnectionString: "MyConnection")
        {

        }

        public virtual DbSet<Film> Filmovi_info { get; set; }
        public virtual DbSet<ProekcijaNaFilm> Proekcii_filmovi { get; set; }
        public virtual DbSet<Akter> Akteri { get; set; }
        public virtual DbSet<Proekcija> Proekcii { get; set; }
        public virtual DbSet<Se_proektira_vo> Se_Proektira_Vos{ get; set; }

        public virtual DbSet<ProsecenPrometPoMesec> ProsecenPromets { get; set; }
        public virtual DbSet<NajredovenKorisnik> NajredovniKorisnici { get; set; }


        public System.Data.Entity.DbSet<OnlineRezNaBiletZaKino.Models.InfoBilet> InfoBilets { get; set; }

        public System.Data.Entity.DbSet<OnlineRezNaBiletZaKino.Models.Korisnik> Korisniks { get; set; }

        public System.Data.Entity.DbSet<OnlineRezNaBiletZaKino.Models.BILET> BILETs { get; set; }
        public virtual DbSet<FilmNaGodinata> FilmoviNaGodinata { get; set; }
    }
}