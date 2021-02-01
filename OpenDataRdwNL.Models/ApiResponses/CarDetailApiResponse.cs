namespace OpenDataRdwNL.Models.ApiResponses
{
    public class CarDetailApiResponse
    {
        public string kenteken { get; set; }
        public string voertuigsoort{ get; set; }
        public string merk{ get; set; }
        public string handelsbenaming{ get; set; }
        public int datum_tenaamstelling{ get; set; }
        public int bruto_bpm { get; set; }
        public string inrichting{ get; set; }
        public string eerste_kleur{ get; set; }
        public string tweede_kleur{ get; set; }
        public int massa_ledig_voertuig{ get; set; }
        public int toegestane_maximum_massa_voertuig{ get; set; }
        public int datum_eerste_toelating{ get; set; }
        public int datum_eerste_afgifte_nederland{ get; set; }
        public string wacht_op_keuren{ get; set; }
        public string wam_verzekerd{ get; set; }
        public int  laadvermogen{ get; set; }
        public int aantal_deuren{ get; set; }
        public int aantal_wielen{ get; set; }
        public int afstand_hart_koppeling_tot_achterzijde_voertuig{ get; set; }
        public int afstand_voorzijde_voertuig_tot_hart_koppeling{ get; set; }
        public int lengte{ get; set; }
        public int breedte{ get; set; }
        public string europese_voertuigcategorie{ get; set; }
        public string plaats_chassisnummer{ get; set; }
        public int technische_max_massa_voertuig{ get; set; }
        public int volgnummer_wijziging_eu_typegoedkeuring{ get; set; }
        public int wielbasis{ get; set; }
        public string export_indicator{ get; set; }
        public string openstaande_terugroepactie_indicator{ get; set; }
        public string taxi_indicator{ get; set; }
        public int maximum_massa_samenstelling{ get; set; }
    }
}