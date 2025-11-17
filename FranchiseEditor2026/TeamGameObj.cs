using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FranchiseEditor2026
{
    public class TeamGameObj
    {
        private int gameID, teamID, scoreO, scoreD, passO, passD, rushO, rushD, firsts, trdConv, trdAtt, turnovers, rzTDO, rzAttO, rzTDD, rzAttD, pen, penyds;
        private string timeOP;

        public TeamGameObj()
        {
            gameID = 0;
            teamID = 0;
            scoreO = 0;
            scoreD = 0;
            passO = 0;
            rushO = 0;
            passD = 0;
            rushD = 0;
            firsts = 0;
            trdConv = 0;
            trdAtt = 0;
            turnovers = 0;
            rzTDO = 0;
            rzAttO = 0;
            rzTDD = 0;
            rzAttD = 0;
            timeOP = "";
            pen = 0;
            penyds = 0;
        }

        public int GameID { get { return gameID; } set { gameID = value; } }
        public int TeamID { get { return teamID; } set { teamID = value; } }
        public int ScoreO { get { return scoreO; } set { scoreO = value; } }
        public int ScoreD { get { return scoreD; } set { scoreD = value; } }
        public int PassO { get { return passO; } set { passO = value; } }
        public int RushO { get { return rushO; } set { rushO = value; } }
        public int PassD { get { return passD; } set { passD = value; } }
        public int RushD { get { return rushD; } set { rushD = value; } }
        public int FirstDowns { get { return firsts; } set { firsts = value; } }
        public int ThirdConvs { get { return trdConv; } set { trdConv = value; } }
        public int ThirdAtts { get { return trdAtt; } set { trdAtt = value; } }
        public int Turnovers { get { return turnovers; } set { turnovers = value; } }
        public int RZTDO { get { return rzTDO; } set { rzTDO = value; } }
        public int RZATTO { get { return rzAttO; } set { rzAttO = value; } }
        public int RZTDD { get { return rzTDD; } set { rzTDD = value; } }
        public int RZATTD { get { return rzAttD; } set { rzAttD = value; } }
        public string TimeOfPossession { get { return timeOP; } set { timeOP = value; } }
        public int Penalties { get { return pen; } set { pen = value; } }
        public int PenaltyYards { get { return penyds; } set { penyds = value; } }
    }
}