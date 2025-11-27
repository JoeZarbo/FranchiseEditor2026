using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Text;

namespace FranchiseEditor2026
{
    public class PlayerGameObj
    {
        private string playerID, result, fname, lname;
        private int year, week, team, opp, location, cmp, passatt, passyds, passtd, passint, passsk, rushatt, rushyds, rushtd, receptions, recyds, rectd, solotak, asttak, tfl, defint, intyds, inttd, pd, fmb, ff, fr, fyds, ftd, defblock, kr, kryds, krtd, pr, pryds, prtd, pnt, pntyds, retyds, tb, in20, puntblock, xpm, xpa, fgm, fga, fgblock, sfty, tgt, fgLong;
        private decimal defsk;

        public PlayerGameObj(string playerID, string fname, string lname)
        {
            this.playerID = playerID;
            result = "";
            this.fname = fname;
            this.lname = lname;
            year = 0;
            week = 0;
            team = 0;
            opp = 0;
            location = 0;
            cmp = 0;
            passatt = 0;
            passyds = 0;
            passtd = 0;
            passint = 0;
            passsk = 0;
            rushatt = 0;
            rushyds = 0;
            rushtd = 0;
            receptions = 0;
            recyds = 0;
            rectd = 0;
            solotak = 0;
            asttak = 0;
            tfl = 0;
            defint = 0;
            intyds = 0;
            inttd = 0;
            pd = 0;
            fmb = 0;
            ff = 0;
            fr = 0;
            fyds = 0;
            ftd = 0;
            defblock = 0;
            kr = 0;
            kryds = 0;
            krtd = 0;
            pr = 0;
            pryds = 0;
            prtd = 0;
            pnt = 0;
            pntyds = 0;
            retyds = 0;
            tb = 0;
            in20 = 0;
            puntblock = 0;
            xpm = 0;
            xpa = 0;
            fgm = 0;
            fga = 0;
            fgblock = 0;
            sfty = 0;
            tgt = 0;
            fgLong = 0;
            defsk = 0;
        }

        public string PlayerID { get { return playerID; } }
        public string Result { get { return result; } set { result = value; } }
        public string FName { get { return fname; } set { fname = value; } }
        public string LName { get { return lname; } set { lname = value; } }
        public int Year { get { return year; } set { year = value; } }
        public int Week { get { return week; } set { week = value; } }
        public int Team { get { return team; } set { team = value; } }
        public int Opp { get { return opp; } set { opp = value; } }
        public int Location { get { return location; } set { location = value; } }
        public int Cmp { get { return cmp; } set { cmp = value; } }
        public int PassAtt { get { return passatt; } set { passatt = value; } }
        public int PassYds { get { return passyds; } set { passyds = value; } }
        public int PassTD { get { return passtd; } set { passtd = value; } }
        public int PassINT { get { return passint; } set { passint = value; } }
        public int PassSK { get { return passsk; } set { passsk = value; } }
        public int RushAtt { get { return rushatt; } set { rushatt = value; } }
        public int RushYds { get { return rushyds; } set { rushyds = value; } }
        public int RushTD { get { return rushtd; } set { rushtd = value; } }
        public int Receptions { get { return receptions; } set { receptions = value; } }
        public int RecYds { get { return recyds; } set { recyds = value; } }
        public int RecTD { get { return rectd; } set { rectd = value; } }
        public int SoloTak { get { return solotak; } set { solotak = value; } }
        public int AstTak { get { return asttak; } set { asttak = value; } }
        public int TFL { get { return tfl; } set { tfl = value; } }
        public int DefINT { get { return defint; } set { defint = value; } }
        public int IntYds { get { return intyds; } set { intyds = value; } }
        public int IntTD { get { return inttd; } set { inttd = value; } }
        public int PD { get { return pd; } set { pd = value; } }
        public int Fmb { get { return fmb; } set { fmb = value; } }
        public int FF { get { return ff; } set { ff = value; } }
        public int FR { get { return fr; } set { fr = value; } }
        public int FYds { get { return fyds; } set { fyds = value; } }
        public int FTD { get { return ftd; } set { ftd = value; } }
        public int DefBlock { get { return defblock; } set { defblock = value; } }
        public int KR { get { return kr; } set { kr = value; } }
        public int KRYds { get { return kryds; } set { kryds = value; } }
        public int KRTD { get { return krtd; } set { krtd = value; } }
        public int PR { get { return pr; } set { pr = value; } }
        public int PRYds { get { return pryds; } set { pryds = value; } }
        public int PRTD { get { return prtd; } set { prtd = value; } }
        public int Pnt { get { return pnt; } set { pnt = value; } }
        public int PntYds { get { return pntyds; } set { pntyds = value; } }
        public int RetYds { get { return retyds; } set { retyds = value; } }
        public int TB { get { return tb; } set { tb = value; } }
        public int In20 { get { return in20; } set { in20 = value; } }
        public int PuntBlock { get { return puntblock; } set { puntblock = value; } }
        public int XPM { get { return xpm; } set { xpm = value; } }
        public int XPA { get { return xpa; } set { xpa = value; } }
        public int FGM { get { return fgm; } set { fgm = value; } }
        public int FGA { get { return fga; } set { fga = value; } }
        public int FGBlock { get { return fgblock; } set { fgblock = value; } }
        public int Safety { get { return sfty; } set { sfty = value; } }
        public int Target { get { return tgt; } set { tgt = value; } }
        public int FGLong { get { return fgLong; } set { fgLong = value; } }
        public decimal DefSK { get { return defsk; } set { defsk = value; } }
        public string FullName => $"{FName} {LName}";
    }

    public class PlayerData
    {
        public BindingList<PlayerGameObj> Players { get; } = new();
    }
}
