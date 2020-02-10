using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Practica2.Controllers
{
    public class TablaController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Periodica()
        {
            string[] elementos = new string[121];
            elementos[1] = "H";
            elementos[2] = "He";
            elementos[3] = "Li";
            elementos[4] = "Be";
            elementos[5] = "B";
            elementos[6] = "C";
            elementos[7] = "N";
            elementos[8] = "O";
            elementos[9] = "F";
            elementos[10] = "Ne";
            elementos[11] = "Na";
            elementos[12] = "Mg";
            elementos[13] = "Al";
            elementos[14] = "Si";
            elementos[15] = "P";
            elementos[16] = "S";
            elementos[17] = "Ci";
            elementos[18] = "Ar";
            elementos[19] = "K";
            elementos[20] = "Ca";
            elementos[21] = "Sc";
            elementos[22] = "Ti";
            elementos[23] = "V";
            elementos[24] = "Cr";
            elementos[25] = "Mn";
            elementos[26] = "Fe";
            elementos[27] = "Co";
            elementos[28] = "Ni";
            elementos[29] = "Cu";
            elementos[30] = "Zn";
            elementos[31] = "Ga";
            elementos[32] = "Ge";
            elementos[33] = "As";
            elementos[34] = "Se";
            elementos[35] = "Br";
            elementos[36] = "Kr";
            elementos[37] = "Rb";
            elementos[38] = "Sr";
            elementos[39] = "Y";
            elementos[40] = "Zr";
            elementos[41] = "Nb";
            elementos[42] = "Mo";
            elementos[43] = "Tc";
            elementos[44] = "Ru";
            elementos[45] = "Rh";
            elementos[46] = "Pd";
            elementos[47] = "Ag";
            elementos[48] = "Cd";
            elementos[49] = "In";
            elementos[50] = "Sn";
            elementos[51] = "Sb";
            elementos[52] = "Te";
            elementos[53] = "I";
            elementos[54] = "Xe";
            elementos[55] = "Cs";
            elementos[56] = "Ba";
            //los numeros no coinciden con los elementos
            elementos[57] = "Lu";
            elementos[58] = "Hf";
            elementos[59] = "Ta";
            elementos[60] = "W";
            elementos[61] = "Re";
            elementos[62] = "Os";
            elementos[63] = "Ir";
            elementos[64] = "Pt";
            elementos[65] = "Au";
            elementos[66] = "Hg";
            elementos[67] = "Tl";
            elementos[68] = "Pb";
            elementos[69] = "Bi";
            elementos[70] = "Po";
            elementos[71] = "At";
            elementos[72] = "Rn";
            elementos[73] = "Fr";
            elementos[74] = "Ra";
            elementos[75] = "Lr";
            elementos[76] = "Rf";
            elementos[77] = "Db";
            elementos[78] = "Sg";
            elementos[79] = "Bh";
            elementos[80] = "Hs";
            elementos[81] = "Mt";
            elementos[82] = "Ds";
            elementos[83] = "Rg";
            elementos[84] = "Cn";
            elementos[85] = "Nh";
            elementos[86] = "FI";
            elementos[87] = "Mc";
            elementos[88] = "Lv";
            elementos[89] = "Ts";
            elementos[90] = "Og";
            elementos[91] = "La";
            elementos[92] = "Ce";
            elementos[93] = "Pr";
            elementos[94] = "Nd";
            elementos[95] = "Pm";
            elementos[96] = "Sm";
            elementos[97] = "Eu";
            elementos[98] = "Gd";
            elementos[99] = "Tb";
            elementos[100] = "Dy";
            elementos[101] = "Ho";
            elementos[102] = "Er";
            elementos[103] = "Tm";
            elementos[104] = "Yb";
            elementos[105] = "Lu";
            elementos[106] = "Ac";
            elementos[107] = "Th";
            elementos[108] = "Pa";
            elementos[109] = "U";
            elementos[110] = "Np";
            elementos[111] = "Pu";
            elementos[112] = "Am";
            elementos[113] = "Cm";
            elementos[114] = "Bk";
            elementos[115] = "Cf";
            elementos[116] = "Es";
            elementos[117] = "Fm";
            elementos[118] = "Md";
            elementos[119] = "No";
            elementos[120] = "Lr";


            ViewBag.Resultado = elementos;
            return View();
        }
    }
}