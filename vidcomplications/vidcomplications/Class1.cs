using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidcomplications
{
    public class Class1
    {


        public static string b_MLP_23_17_6(double[] ContInputs, string[] CatInputs)

        {

            //"Input Variable" comment is added besides Input(Response) variables.



            int Cont_idx = 0;

            int Cat_idx = 0;

            double XCMH = ContInputs[Cont_idx++]; //Input Variable

            string PCKBCA = CatInputs[Cat_idx++]; //Input Variable

            string KBOCA = CatInputs[Cat_idx++]; //Input Variable

            string CCBCA = CatInputs[Cat_idx++]; //Input Variable

            string ONMK = CatInputs[Cat_idx++]; //Input Variable

            string NYHA = CatInputs[Cat_idx++]; //Input Variable

            string XOBL = CatInputs[Cat_idx++]; //Input Variable

            string __statist_PredCat = "";

            string[] __statist_DCats = new string[6];

            __statist_DCats[0] = "OHMK";

            __statist_DCats[1] = "OIM";

            __statist_DCats[2] = "TIA";

            __statist_DCats[3] = "hematoma";

            __statist_DCats[4] = "pneumonia";

            __statist_DCats[5] = "thrombosis";



            double __statist_ConfLevel = 3.0E-300;



            double[] __statist_max_input = new double[1];

            __statist_max_input[0] = 4.00000000000000e+000;



            double[] __statist_min_input = new double[1];

            __statist_min_input[0] = 3.00000000000000e+000;





            double[,] __statist_i_h_wts = new double[17, 23];



            __statist_i_h_wts[0, 0] = -3.66149037831303e-001;

            __statist_i_h_wts[0, 1] = -4.10000590520542e-001;

            __statist_i_h_wts[0, 2] = 6.70278867575884e-001;

            __statist_i_h_wts[0, 3] = 5.73639688489995e-001;

            __statist_i_h_wts[0, 4] = -1.42460646790471e+000;

            __statist_i_h_wts[0, 5] = 4.50819046905812e-001;

            __statist_i_h_wts[0, 6] = 3.38546590587184e-001;

            __statist_i_h_wts[0, 7] = 1.75689980715626e+000;

            __statist_i_h_wts[0, 8] = -1.85223723457563e+000;

            __statist_i_h_wts[0, 9] = 2.86514404498972e-001;

            __statist_i_h_wts[0, 10] = 5.63924489364250e-001;

            __statist_i_h_wts[0, 11] = -3.67913488196671e-001;

            __statist_i_h_wts[0, 12] = 5.66813003770821e-001;

            __statist_i_h_wts[0, 13] = 4.97652340462742e-001;

            __statist_i_h_wts[0, 14] = -8.59370290218771e-001;

            __statist_i_h_wts[0, 15] = 6.74066720706972e-001;

            __statist_i_h_wts[0, 16] = -1.36579740377212e+000;

            __statist_i_h_wts[0, 17] = 8.89724925277532e-001;

            __statist_i_h_wts[0, 18] = -2.39456590397006e-004;

            __statist_i_h_wts[0, 19] = 6.34436857825650e-001;

            __statist_i_h_wts[0, 20] = -7.92260725956119e-001;

            __statist_i_h_wts[0, 21] = 8.18138832863087e-001;

            __statist_i_h_wts[0, 22] = -4.61385706107751e-001;



            __statist_i_h_wts[1, 0] = -6.30019755660798e-001;

            __statist_i_h_wts[1, 1] = 1.96228749597943e-001;

            __statist_i_h_wts[1, 2] = 7.57328790154578e-001;

            __statist_i_h_wts[1, 3] = 2.04683299003973e-001;

            __statist_i_h_wts[1, 4] = -9.56846866586136e-001;

            __statist_i_h_wts[1, 5] = 6.92102034630001e-001;

            __statist_i_h_wts[1, 6] = -1.28276063001203e+000;

            __statist_i_h_wts[1, 7] = 5.56002176737992e-002;

            __statist_i_h_wts[1, 8] = -4.26708485615943e-001;

            __statist_i_h_wts[1, 9] = -1.35715839628981e-002;

            __statist_i_h_wts[1, 10] = 2.44436953204886e-001;

            __statist_i_h_wts[1, 11] = -6.30326108386403e-001;

            __statist_i_h_wts[1, 12] = 2.43388122662517e-001;

            __statist_i_h_wts[1, 13] = -4.07876723975010e-001;

            __statist_i_h_wts[1, 14] = -2.21907710287861e-001;

            __statist_i_h_wts[1, 15] = -4.15733166072854e-001;

            __statist_i_h_wts[1, 16] = 7.34397849728224e-001;

            __statist_i_h_wts[1, 17] = -7.02083721739416e-001;

            __statist_i_h_wts[1, 18] = 1.20820988388193e-003;

            __statist_i_h_wts[1, 19] = 2.51086302392541e-001;

            __statist_i_h_wts[1, 20] = -6.63291720588051e-001;

            __statist_i_h_wts[1, 21] = 6.19650041084090e-001;

            __statist_i_h_wts[1, 22] = -5.87989171652153e-001;



            __statist_i_h_wts[2, 0] = 4.27996157501196e-001;

            __statist_i_h_wts[2, 1] = -3.95749323574223e-001;

            __statist_i_h_wts[2, 2] = 1.78873938653454e-002;

            __statist_i_h_wts[2, 3] = 6.92060988555805e-001;

            __statist_i_h_wts[2, 4] = 4.01255213070345e-001;

            __statist_i_h_wts[2, 5] = -3.53372752780500e-001;

            __statist_i_h_wts[2, 6] = 6.46216960507286e-002;

            __statist_i_h_wts[2, 7] = -2.24338022764277e-001;

            __statist_i_h_wts[2, 8] = 4.65101490936478e-001;

            __statist_i_h_wts[2, 9] = 1.96009034690768e-001;

            __statist_i_h_wts[2, 10] = 7.20998364147072e-003;

            __statist_i_h_wts[2, 11] = 4.30840496017467e-001;

            __statist_i_h_wts[2, 12] = 6.41812959731968e-003;

            __statist_i_h_wts[2, 13] = -3.42380106542484e-001;

            __statist_i_h_wts[2, 14] = 7.66206658776363e-001;

            __statist_i_h_wts[2, 15] = -4.05753303593484e-001;

            __statist_i_h_wts[2, 16] = 8.80332190033266e-001;

            __statist_i_h_wts[2, 17] = -3.82430094835241e-002;

            __statist_i_h_wts[2, 18] = 1.50201270002056e-004;

            __statist_i_h_wts[2, 19] = 6.18674829968625e-001;

            __statist_i_h_wts[2, 20] = 2.61692924142848e-002;

            __statist_i_h_wts[2, 21] = -1.48808678383532e-001;

            __statist_i_h_wts[2, 22] = -4.88611791715496e-002;



            __statist_i_h_wts[3, 0] = -3.78434912527137e-001;

            __statist_i_h_wts[3, 1] = -5.69227072434216e-002;

            __statist_i_h_wts[3, 2] = -2.75499912267190e-001;

            __statist_i_h_wts[3, 3] = -1.29466943129656e-001;

            __statist_i_h_wts[3, 4] = 2.69797146843860e-002;

            __statist_i_h_wts[3, 5] = 4.07128736778814e-002;

            __statist_i_h_wts[3, 6] = -5.99306048076582e-002;

            __statist_i_h_wts[3, 7] = 5.72675991978828e-002;

            __statist_i_h_wts[3, 8] = -2.70287562329260e-001;

            __statist_i_h_wts[3, 9] = -2.31068203420402e-001;

            __statist_i_h_wts[3, 10] = -5.98816358205968e-002;

            __statist_i_h_wts[3, 11] = -3.81568049627100e-001;

            __statist_i_h_wts[3, 12] = -6.25385346940256e-002;

            __statist_i_h_wts[3, 13] = -3.91014886852456e-001;

            __statist_i_h_wts[3, 14] = 1.04616108108113e-002;

            __statist_i_h_wts[3, 15] = -6.21235612181587e-001;

            __statist_i_h_wts[3, 16] = 2.39319519246532e-001;

            __statist_i_h_wts[3, 17] = -6.46068323852573e-002;

            __statist_i_h_wts[3, 18] = -3.20400449874521e-003;

            __statist_i_h_wts[3, 19] = -2.67958545633576e-001;

            __statist_i_h_wts[3, 20] = -8.18706993317146e-002;

            __statist_i_h_wts[3, 21] = 2.33974124475705e-001;

            __statist_i_h_wts[3, 22] = -3.25398498574863e-001;



            __statist_i_h_wts[4, 0] = 5.14643153153477e-002;

            __statist_i_h_wts[4, 1] = 1.42138359531418e-001;

            __statist_i_h_wts[4, 2] = -5.26332459640465e-001;

            __statist_i_h_wts[4, 3] = -4.34671818006173e-001;

            __statist_i_h_wts[4, 4] = -3.01510447558282e-001;

            __statist_i_h_wts[4, 5] = 4.40818968947396e-001;

            __statist_i_h_wts[4, 6] = -4.48129959984274e-002;

            __statist_i_h_wts[4, 7] = -1.12953422498066e+000;

            __statist_i_h_wts[4, 8] = 2.62455618275844e-001;

            __statist_i_h_wts[4, 9] = 1.42057695944097e-001;

            __statist_i_h_wts[4, 10] = -7.78886318079523e-001;

            __statist_i_h_wts[4, 11] = 5.26375511037617e-002;

            __statist_i_h_wts[4, 12] = -7.77519072434800e-001;

            __statist_i_h_wts[4, 13] = -3.80847581309069e-001;

            __statist_i_h_wts[4, 14] = 4.34957473782531e-001;

            __statist_i_h_wts[4, 15] = -7.18219410792827e-001;

            __statist_i_h_wts[4, 16] = 5.10196893859495e-001;

            __statist_i_h_wts[4, 17] = -5.14898502077109e-001;

            __statist_i_h_wts[4, 18] = 2.18702031130137e-003;

            __statist_i_h_wts[4, 19] = -6.60295968172681e-001;

            __statist_i_h_wts[4, 20] = -2.23114013322092e-001;

            __statist_i_h_wts[4, 21] = -3.52567306594935e-001;

            __statist_i_h_wts[4, 22] = 5.14127660966119e-001;



            __statist_i_h_wts[5, 0] = 9.69379479973296e-002;

            __statist_i_h_wts[5, 1] = 5.94947151569444e-001;

            __statist_i_h_wts[5, 2] = 5.15183199032546e-001;

            __statist_i_h_wts[5, 3] = -1.00368127200200e-001;

            __statist_i_h_wts[5, 4] = -7.80438687217244e-001;

            __statist_i_h_wts[5, 5] = 8.76715864569613e-001;

            __statist_i_h_wts[5, 6] = -1.00705723688375e+000;

            __statist_i_h_wts[5, 7] = -1.70851875184237e-001;

            __statist_i_h_wts[5, 8] = 1.91745088190579e-001;

            __statist_i_h_wts[5, 9] = 7.91341047087945e-002;

            __statist_i_h_wts[5, 10] = 4.41165869058557e-003;

            __statist_i_h_wts[5, 11] = 9.52080917473163e-002;

            __statist_i_h_wts[5, 12] = 7.90887076623631e-003;

            __statist_i_h_wts[5, 13] = -7.35548515109837e-001;

            __statist_i_h_wts[5, 14] = 8.32531639693942e-001;

            __statist_i_h_wts[5, 15] = 4.53273497667671e-001;

            __statist_i_h_wts[5, 16] = -6.39474555016097e-003;

            __statist_i_h_wts[5, 17] = -3.48414850508179e-001;

            __statist_i_h_wts[5, 18] = 1.90765378690674e-003;

            __statist_i_h_wts[5, 19] = -5.14755340750445e-001;

            __statist_i_h_wts[5, 20] = -2.59971057412824e-001;

            __statist_i_h_wts[5, 21] = 4.80525472874427e-002;

            __statist_i_h_wts[5, 22] = 8.28235517411031e-001;



            __statist_i_h_wts[6, 0] = 1.16944238574069e-001;

            __statist_i_h_wts[6, 1] = -5.36757752000883e-003;

            __statist_i_h_wts[6, 2] = 2.24340527357881e-001;

            __statist_i_h_wts[6, 3] = 8.60818748276819e-001;

            __statist_i_h_wts[6, 4] = -1.72398124564996e-001;

            __statist_i_h_wts[6, 5] = -7.92848012701176e-001;

            __statist_i_h_wts[6, 6] = 2.18109375414757e-002;

            __statist_i_h_wts[6, 7] = 7.24592234362907e-001;

            __statist_i_h_wts[6, 8] = -4.56499241287172e-001;

            __statist_i_h_wts[6, 9] = -1.37268005923959e-001;

            __statist_i_h_wts[6, 10] = 2.23449295194040e-002;

            __statist_i_h_wts[6, 11] = 1.15119605695537e-001;

            __statist_i_h_wts[6, 12] = 2.56147417543242e-002;

            __statist_i_h_wts[6, 13] = 1.59465407355919e-001;

            __statist_i_h_wts[6, 14] = -4.40294410288913e-002;

            __statist_i_h_wts[6, 15] = 4.55944508838343e-001;

            __statist_i_h_wts[6, 16] = -1.96421697341727e-002;

            __statist_i_h_wts[6, 17] = -2.98162730400194e-001;

            __statist_i_h_wts[6, 18] = 1.69296595874584e-003;

            __statist_i_h_wts[6, 19] = 4.91030600501361e-001;

            __statist_i_h_wts[6, 20] = -4.14226017603585e-001;

            __statist_i_h_wts[6, 21] = 8.44248755577400e-002;

            __statist_i_h_wts[6, 22] = -2.41698253609391e-002;



            __statist_i_h_wts[7, 0] = -6.40035646037987e-002;

            __statist_i_h_wts[7, 1] = 3.93776862647726e-002;

            __statist_i_h_wts[7, 2] = -3.75488426003961e-001;

            __statist_i_h_wts[7, 3] = 3.16674313314973e-001;

            __statist_i_h_wts[7, 4] = 4.88938290925420e-001;

            __statist_i_h_wts[7, 5] = 1.12560238131999e-002;

            __statist_i_h_wts[7, 6] = -1.64104310025912e-001;

            __statist_i_h_wts[7, 7] = 1.06836176646110e+000;

            __statist_i_h_wts[7, 8] = 5.17622280385903e-002;

            __statist_i_h_wts[7, 9] = -7.97498404430708e-001;

            __statist_i_h_wts[7, 10] = 3.81750492115664e-001;

            __statist_i_h_wts[7, 11] = -5.93355253811637e-002;

            __statist_i_h_wts[7, 12] = 3.86520233253668e-001;

            __statist_i_h_wts[7, 13] = 5.12407738198360e-001;

            __statist_i_h_wts[7, 14] = -5.76720775750532e-001;

            __statist_i_h_wts[7, 15] = 5.20581783823566e-001;

            __statist_i_h_wts[7, 16] = -2.99677193941631e-001;

            __statist_i_h_wts[7, 17] = 9.92721961388984e-002;

            __statist_i_h_wts[7, 18] = -1.21313129788090e-003;

            __statist_i_h_wts[7, 19] = 3.85976524504099e-001;

            __statist_i_h_wts[7, 20] = -5.01509158264916e-001;

            __statist_i_h_wts[7, 21] = 1.26050857075859e-001;

            __statist_i_h_wts[7, 22] = 3.14741568168645e-001;



            __statist_i_h_wts[8, 0] = 3.68240802383079e-001;

            __statist_i_h_wts[8, 1] = -1.31195626248221e+000;

            __statist_i_h_wts[8, 2] = -2.98074194291485e-001;

            __statist_i_h_wts[8, 3] = -1.45220936185906e-001;

            __statist_i_h_wts[8, 4] = 4.59352580970398e-001;

            __statist_i_h_wts[8, 5] = 7.03104158859231e-001;

            __statist_i_h_wts[8, 6] = 1.10700408806125e+000;

            __statist_i_h_wts[8, 7] = -1.29717053150580e-001;

            __statist_i_h_wts[8, 8] = 3.36507858661145e-001;

            __statist_i_h_wts[8, 9] = 3.07342037933522e-001;

            __statist_i_h_wts[8, 10] = 1.43340335280359e-001;

            __statist_i_h_wts[8, 11] = 3.76550737320441e-001;

            __statist_i_h_wts[8, 12] = 1.48069259419816e-001;

            __statist_i_h_wts[8, 13] = 3.68623662385134e-001;

            __statist_i_h_wts[8, 14] = 2.66249948920519e-003;

            __statist_i_h_wts[8, 15] = -2.73499342767062e-001;

            __statist_i_h_wts[8, 16] = 1.52079444468944e-001;

            __statist_i_h_wts[8, 17] = 6.43535279273206e-001;

            __statist_i_h_wts[8, 18] = 1.43868071881996e-003;

            __statist_i_h_wts[8, 19] = -1.65988693566687e-001;

            __statist_i_h_wts[8, 20] = 5.71303194160960e-001;

            __statist_i_h_wts[8, 21] = 5.56387257792276e-001;

            __statist_i_h_wts[8, 22] = -4.42165939317893e-001;



            __statist_i_h_wts[9, 0] = -9.97816589566723e-002;

            __statist_i_h_wts[9, 1] = -6.11552678697175e-001;

            __statist_i_h_wts[9, 2] = 5.65092626016561e-001;

            __statist_i_h_wts[9, 3] = 6.69798762750312e-001;

            __statist_i_h_wts[9, 4] = 1.60156076728680e-001;

            __statist_i_h_wts[9, 5] = -8.25323872206130e-001;

            __statist_i_h_wts[9, 6] = 4.54065294661922e-001;

            __statist_i_h_wts[9, 7] = 7.73273841300462e-001;

            __statist_i_h_wts[9, 8] = 6.22997305967251e-002;

            __statist_i_h_wts[9, 9] = -4.22261390281143e-001;

            __statist_i_h_wts[9, 10] = 5.15018433619364e-001;

            __statist_i_h_wts[9, 11] = -1.00902225275892e-001;

            __statist_i_h_wts[9, 12] = 5.13097389201617e-001;

            __statist_i_h_wts[9, 13] = -2.20244120669511e-001;

            __statist_i_h_wts[9, 14] = 1.16766511948673e-001;

            __statist_i_h_wts[9, 15] = 7.52008936312791e-001;

            __statist_i_h_wts[9, 16] = -6.39123054056878e-001;

            __statist_i_h_wts[9, 17] = 3.03427666483113e-001;

            __statist_i_h_wts[9, 18] = 1.89839185547447e-003;

            __statist_i_h_wts[9, 19] = 9.33027048471250e-001;

            __statist_i_h_wts[9, 20] = -1.59216351045251e-001;

            __statist_i_h_wts[9, 21] = -4.64185498106106e-001;

            __statist_i_h_wts[9, 22] = 1.11165522422729e-001;



            __statist_i_h_wts[10, 0] = 2.86902098619789e-001;

            __statist_i_h_wts[10, 1] = -4.71822581878378e-001;

            __statist_i_h_wts[10, 2] = -2.81510708563752e-001;

            __statist_i_h_wts[10, 3] = -1.40624050394393e-001;

            __statist_i_h_wts[10, 4] = -2.47951221855395e-001;

            __statist_i_h_wts[10, 5] = -2.92499504707179e-001;

            __statist_i_h_wts[10, 6] = 8.42959676645554e-001;

            __statist_i_h_wts[10, 7] = -7.79605173080245e-001;

            __statist_i_h_wts[10, 8] = 3.65087085368047e-001;

            __statist_i_h_wts[10, 9] = -1.71133506576596e-001;

            __statist_i_h_wts[10, 10] = -8.76545945947632e-001;

            __statist_i_h_wts[10, 11] = 2.92790628617761e-001;

            __statist_i_h_wts[10, 12] = -8.74764622283589e-001;

            __statist_i_h_wts[10, 13] = 7.96964161206901e-001;

            __statist_i_h_wts[10, 14] = -5.09055700435572e-001;

            __statist_i_h_wts[10, 15] = -6.92669353203939e-001;

            __statist_i_h_wts[10, 16] = 6.15747243667141e-001;

            __statist_i_h_wts[10, 17] = -5.06811598998195e-001;

            __statist_i_h_wts[10, 18] = -9.29749065357780e-004;

            __statist_i_h_wts[10, 19] = -4.03587346210390e-001;

            __statist_i_h_wts[10, 20] = 2.73517480749768e-001;

            __statist_i_h_wts[10, 21] = -5.51044534309730e-001;

            __statist_i_h_wts[10, 22] = 9.45530914194779e-002;



            __statist_i_h_wts[11, 0] = -1.90596104853469e-001;

            __statist_i_h_wts[11, 1] = -7.21858684210849e-001;

            __statist_i_h_wts[11, 2] = -3.66353325508544e-001;

            __statist_i_h_wts[11, 3] = -1.81913084311234e-002;

            __statist_i_h_wts[11, 4] = 8.11990838009903e-001;

            __statist_i_h_wts[11, 5] = 6.87645852863877e-002;

            __statist_i_h_wts[11, 6] = 4.32749771725198e-001;

            __statist_i_h_wts[11, 7] = 1.21025723562112e-001;

            __statist_i_h_wts[11, 8] = -2.70205703924353e-001;

            __statist_i_h_wts[11, 9] = 3.50660484272760e-001;

            __statist_i_h_wts[11, 10] = 3.94286820590600e-001;

            __statist_i_h_wts[11, 11] = -1.90276961385194e-001;

            __statist_i_h_wts[11, 12] = 3.95382927841201e-001;

            __statist_i_h_wts[11, 13] = 2.33070108966391e-001;

            __statist_i_h_wts[11, 14] = -4.24864244555244e-001;

            __statist_i_h_wts[11, 15] = -6.25322892686063e-002;

            __statist_i_h_wts[11, 16] = 1.39435468968231e-001;

            __statist_i_h_wts[11, 17] = 1.21773407896712e-001;

            __statist_i_h_wts[11, 18] = -7.96494018094613e-004;

            __statist_i_h_wts[11, 19] = 6.13932326288987e-001;

            __statist_i_h_wts[11, 20] = 3.67875375717425e-001;

            __statist_i_h_wts[11, 21] = -2.98888257024661e-001;

            __statist_i_h_wts[11, 22] = -4.79881223973036e-001;



            __statist_i_h_wts[12, 0] = 1.47502145183586e-001;

            __statist_i_h_wts[12, 1] = -5.19793090520393e-001;

            __statist_i_h_wts[12, 2] = -2.96433537536721e-001;

            __statist_i_h_wts[12, 3] = -1.59954107164531e-001;

            __statist_i_h_wts[12, 4] = 5.31699087865137e-001;

            __statist_i_h_wts[12, 5] = 2.20041025475072e-001;

            __statist_i_h_wts[12, 6] = 6.08712068655166e-001;

            __statist_i_h_wts[12, 7] = 8.91568995934509e-001;

            __statist_i_h_wts[12, 8] = -9.41767306186249e-002;

            __statist_i_h_wts[12, 9] = -4.13604463065901e-001;

            __statist_i_h_wts[12, 10] = 2.39697601933426e-001;

            __statist_i_h_wts[12, 11] = 1.45540292965149e-001;

            __statist_i_h_wts[12, 12] = 2.40429379411343e-001;

            __statist_i_h_wts[12, 13] = 8.12133111614733e-001;

            __statist_i_h_wts[12, 14] = -6.64637955038000e-001;

            __statist_i_h_wts[12, 15] = 2.18857197955583e-001;

            __statist_i_h_wts[12, 16] = -2.97710306471362e-001;

            __statist_i_h_wts[12, 17] = 4.63872834242449e-001;

            __statist_i_h_wts[12, 18] = -3.12021722687279e-003;

            __statist_i_h_wts[12, 19] = 2.95022864619244e-002;

            __statist_i_h_wts[12, 20] = -2.08509797910462e-001;

            __statist_i_h_wts[12, 21] = 2.64531078452287e-001;

            __statist_i_h_wts[12, 22] = 2.99162943550997e-001;



            __statist_i_h_wts[13, 0] = 5.15134823841913e-002;

            __statist_i_h_wts[13, 1] = -7.20956385332561e-002;

            __statist_i_h_wts[13, 2] = -1.56763244701719e-001;

            __statist_i_h_wts[13, 3] = 5.64910235726509e-003;

            __statist_i_h_wts[13, 4] = -3.37503967224227e-001;

            __statist_i_h_wts[13, 5] = 3.68983866138925e-001;

            __statist_i_h_wts[13, 6] = 2.66654827790189e-001;

            __statist_i_h_wts[13, 7] = 1.55767601918633e-001;

            __statist_i_h_wts[13, 8] = -2.63289599391325e-001;

            __statist_i_h_wts[13, 9] = 1.88642111309670e-001;

            __statist_i_h_wts[13, 10] = 3.31604710486976e-002;

            __statist_i_h_wts[13, 11] = 4.81836724421202e-002;

            __statist_i_h_wts[13, 12] = 3.46424770859198e-002;

            __statist_i_h_wts[13, 13] = 9.83215627605601e-002;

            __statist_i_h_wts[13, 14] = -4.57720295178809e-002;

            __statist_i_h_wts[13, 15] = -1.26014652271607e-001;

            __statist_i_h_wts[13, 16] = 3.26130698907136e-001;

            __statist_i_h_wts[13, 17] = -1.19600493910659e-001;

            __statist_i_h_wts[13, 18] = 5.67418620854284e-004;

            __statist_i_h_wts[13, 19] = 2.24302167366121e-001;

            __statist_i_h_wts[13, 20] = -2.31158626715107e-001;

            __statist_i_h_wts[13, 21] = 2.95658939801614e-001;

            __statist_i_h_wts[13, 22] = -2.04542609434245e-001;



            __statist_i_h_wts[14, 0] = 5.39387903102777e-001;

            __statist_i_h_wts[14, 1] = 2.29698936703049e-001;

            __statist_i_h_wts[14, 2] = 1.18237645643256e+000;

            __statist_i_h_wts[14, 3] = -6.26728865951719e-002;

            __statist_i_h_wts[14, 4] = -1.89980494341049e+000;

            __statist_i_h_wts[14, 5] = 1.33882208743574e+000;

            __statist_i_h_wts[14, 6] = -8.84941488191375e-001;

            __statist_i_h_wts[14, 7] = -1.91896882581363e-001;

            __statist_i_h_wts[14, 8] = -6.51154185987257e-001;

            __statist_i_h_wts[14, 9] = 7.46568411918180e-001;

            __statist_i_h_wts[14, 10] = -6.27408354956957e-001;

            __statist_i_h_wts[14, 11] = 5.38192275804133e-001;

            __statist_i_h_wts[14, 12] = -6.28111266042996e-001;

            __statist_i_h_wts[14, 13] = -7.43506350433142e-001;

            __statist_i_h_wts[14, 14] = 1.28122206213495e+000;

            __statist_i_h_wts[14, 15] = 6.35359040855133e-001;

            __statist_i_h_wts[14, 16] = -3.12500367722475e-001;

            __statist_i_h_wts[14, 17] = -4.20746695219916e-001;

            __statist_i_h_wts[14, 18] = 1.62974212479380e-003;

            __statist_i_h_wts[14, 19] = -9.32149062323416e-001;

            __statist_i_h_wts[14, 20] = -4.75531138990714e-001;

            __statist_i_h_wts[14, 21] = -4.96327514641096e-002;

            __statist_i_h_wts[14, 22] = 1.36333700781318e+000;



            __statist_i_h_wts[15, 0] = 1.96405636392784e-001;

            __statist_i_h_wts[15, 1] = -3.50561697779709e-001;

            __statist_i_h_wts[15, 2] = 3.38241861664730e-001;

            __statist_i_h_wts[15, 3] = -3.67816110003714e-001;

            __statist_i_h_wts[15, 4] = -2.72766199722137e-001;

            __statist_i_h_wts[15, 5] = 6.83004766955294e-002;

            __statist_i_h_wts[15, 6] = 8.77816428916078e-001;

            __statist_i_h_wts[15, 7] = 2.53902807239744e-001;

            __statist_i_h_wts[15, 8] = 5.84855616888881e-002;

            __statist_i_h_wts[15, 9] = -2.17085683856430e-002;

            __statist_i_h_wts[15, 10] = 9.02123542961837e-002;

            __statist_i_h_wts[15, 11] = 2.02715564943944e-001;

            __statist_i_h_wts[15, 12] = 9.24828150393505e-002;

            __statist_i_h_wts[15, 13] = -1.06770132297205e-002;

            __statist_i_h_wts[15, 14] = 2.06226359353094e-001;

            __statist_i_h_wts[15, 15] = 9.59530182920285e-002;

            __statist_i_h_wts[15, 16] = -7.46007489843569e-001;

            __statist_i_h_wts[15, 17] = 9.39789003486367e-001;

            __statist_i_h_wts[15, 18] = -3.26982426668733e-003;

            __statist_i_h_wts[15, 19] = -3.10825540137808e-001;

            __statist_i_h_wts[15, 20] = -5.78991409190247e-002;

            __statist_i_h_wts[15, 21] = 2.68070373048043e-001;

            __statist_i_h_wts[15, 22] = 3.89004117955633e-001;



            __statist_i_h_wts[16, 0] = -1.12199113345601e-001;

            __statist_i_h_wts[16, 1] = 1.74898086971094e-001;

            __statist_i_h_wts[16, 2] = 3.27535295251379e-002;

            __statist_i_h_wts[16, 3] = -3.17538950503974e-001;

            __statist_i_h_wts[16, 4] = -5.22397948478214e-001;

            __statist_i_h_wts[16, 5] = 1.08744055542187e+000;

            __statist_i_h_wts[16, 6] = -8.37863126249927e-001;

            __statist_i_h_wts[16, 7] = 5.33301010136638e-001;

            __statist_i_h_wts[16, 8] = -1.00412492182101e+000;

            __statist_i_h_wts[16, 9] = 9.73706931811548e-002;

            __statist_i_h_wts[16, 10] = -2.65170233859100e-001;

            __statist_i_h_wts[16, 11] = -1.11572251645554e-001;

            __statist_i_h_wts[16, 12] = -2.60307247806424e-001;

            __statist_i_h_wts[16, 13] = -6.98125936341328e-001;

            __statist_i_h_wts[16, 14] = 5.89963099553716e-001;

            __statist_i_h_wts[16, 15] = 3.55496290083050e-001;

            __statist_i_h_wts[16, 16] = -1.29516691109000e-001;

            __statist_i_h_wts[16, 17] = -6.05237481987790e-001;

            __statist_i_h_wts[16, 18] = -2.19849059019476e-004;

            __statist_i_h_wts[16, 19] = -1.32445475603278e-001;

            __statist_i_h_wts[16, 20] = -7.25896661271914e-001;

            __statist_i_h_wts[16, 21] = -9.23071374321190e-002;

            __statist_i_h_wts[16, 22] = 5.73558578518934e-001;



            double[,] __statist_h_o_wts = new double[6, 17];



            __statist_h_o_wts[0, 0] = -1.73054869453770e-001;

            __statist_h_o_wts[0, 1] = -2.29730452128394e-001;

            __statist_h_o_wts[0, 2] = -9.00417000652564e-001;

            __statist_h_o_wts[0, 3] = -1.44796127374451e-002;

            __statist_h_o_wts[0, 4] = -1.68840657981437e-001;

            __statist_h_o_wts[0, 5] = 2.05445841932021e-001;

            __statist_h_o_wts[0, 6] = -1.19163433611443e-001;

            __statist_h_o_wts[0, 7] = -6.52436118721186e-001;

            __statist_h_o_wts[0, 8] = -1.86764807503596e-001;

            __statist_h_o_wts[0, 9] = 6.00283641044520e-001;

            __statist_h_o_wts[0, 10] = 3.24569262931652e-002;

            __statist_h_o_wts[0, 11] = 2.63130803823002e-002;

            __statist_h_o_wts[0, 12] = 5.64054065305405e-002;

            __statist_h_o_wts[0, 13] = 2.78447075547783e-002;

            __statist_h_o_wts[0, 14] = 8.40522304830663e-002;

            __statist_h_o_wts[0, 15] = -3.02870596555095e-001;

            __statist_h_o_wts[0, 16] = -3.10325863922233e-001;



            __statist_h_o_wts[1, 0] = -2.42175140422888e-001;

            __statist_h_o_wts[1, 1] = 6.12247816845405e-002;

            __statist_h_o_wts[1, 2] = 1.79083208577994e-001;

            __statist_h_o_wts[1, 3] = -1.85607248009498e-001;

            __statist_h_o_wts[1, 4] = -1.26512276738115e+000;

            __statist_h_o_wts[1, 5] = 9.94955694853299e-002;

            __statist_h_o_wts[1, 6] = -3.96153616804411e-001;

            __statist_h_o_wts[1, 7] = -7.77167512674760e-002;

            __statist_h_o_wts[1, 8] = -5.46785947200696e-001;

            __statist_h_o_wts[1, 9] = -8.04810515997268e-001;

            __statist_h_o_wts[1, 10] = 7.08774384287474e-002;

            __statist_h_o_wts[1, 11] = 6.46632037156334e-001;

            __statist_h_o_wts[1, 12] = 2.66890239704881e-001;

            __statist_h_o_wts[1, 13] = -4.80340495443593e-002;

            __statist_h_o_wts[1, 14] = 3.02231163572508e-001;

            __statist_h_o_wts[1, 15] = 4.58602256167779e-001;

            __statist_h_o_wts[1, 16] = -1.77595946287524e-001;



            __statist_h_o_wts[2, 0] = 1.91569970286255e+000;

            __statist_h_o_wts[2, 1] = 1.99342644407874e+000;

            __statist_h_o_wts[2, 2] = 9.02722368721855e-001;

            __statist_h_o_wts[2, 3] = -4.14884941208853e-001;

            __statist_h_o_wts[2, 4] = 3.65064891000777e-001;

            __statist_h_o_wts[2, 5] = 9.61075764934864e-001;

            __statist_h_o_wts[2, 6] = 5.38681864234969e-001;

            __statist_h_o_wts[2, 7] = -4.65105888448331e-002;

            __statist_h_o_wts[2, 8] = 2.74807164765517e-001;

            __statist_h_o_wts[2, 9] = 7.18552734216691e-001;

            __statist_h_o_wts[2, 10] = 1.69784902364428e+000;

            __statist_h_o_wts[2, 11] = -1.00429844872332e+000;

            __statist_h_o_wts[2, 12] = -2.18985371914675e-002;

            __statist_h_o_wts[2, 13] = -3.04868501245880e-001;

            __statist_h_o_wts[2, 14] = 2.01813868485452e-001;

            __statist_h_o_wts[2, 15] = 5.27927773516873e-001;

            __statist_h_o_wts[2, 16] = 6.72714712341855e-001;



            __statist_h_o_wts[3, 0] = -3.48657100788463e-001;

            __statist_h_o_wts[3, 1] = -5.12770867640801e-001;

            __statist_h_o_wts[3, 2] = 2.50543775016925e-001;

            __statist_h_o_wts[3, 3] = -5.97432008738747e-001;

            __statist_h_o_wts[3, 4] = -3.50252930899712e-001;

            __statist_h_o_wts[3, 5] = -1.17151046798243e-001;

            __statist_h_o_wts[3, 6] = 1.10888947755954e-001;

            __statist_h_o_wts[3, 7] = 4.19577559817318e-001;

            __statist_h_o_wts[3, 8] = 9.25663522699974e-001;

            __statist_h_o_wts[3, 9] = -1.29623995255822e-001;

            __statist_h_o_wts[3, 10] = -3.56800090424381e-001;

            __statist_h_o_wts[3, 11] = -5.45361429333671e-001;

            __statist_h_o_wts[3, 12] = -4.18048575276582e-001;

            __statist_h_o_wts[3, 13] = 1.30559661416153e-002;

            __statist_h_o_wts[3, 14] = -1.32007387431219e+000;

            __statist_h_o_wts[3, 15] = -7.87643393575977e-002;

            __statist_h_o_wts[3, 16] = 4.66016032035681e-001;



            __statist_h_o_wts[4, 0] = -1.42913802927681e-001;

            __statist_h_o_wts[4, 1] = 9.08744453169961e-002;

            __statist_h_o_wts[4, 2] = 1.18956811255510e-001;

            __statist_h_o_wts[4, 3] = 4.39295503542480e-001;

            __statist_h_o_wts[4, 4] = 6.17428432896993e-001;

            __statist_h_o_wts[4, 5] = -4.06611221481892e-001;

            __statist_h_o_wts[4, 6] = 8.67058727980253e-002;

            __statist_h_o_wts[4, 7] = 1.62217555069399e-001;

            __statist_h_o_wts[4, 8] = -2.97829022840293e-001;

            __statist_h_o_wts[4, 9] = -1.76533649201684e-001;

            __statist_h_o_wts[4, 10] = 5.01499732564114e-002;

            __statist_h_o_wts[4, 11] = 8.85510665563077e-002;

            __statist_h_o_wts[4, 12] = 1.32856685060296e-001;

            __statist_h_o_wts[4, 13] = -2.47086961760859e-001;

            __statist_h_o_wts[4, 14] = 1.54317664871286e-001;

            __statist_h_o_wts[4, 15] = 1.98565336462222e-001;

            __statist_h_o_wts[4, 16] = 2.58668012311893e-001;



            __statist_h_o_wts[5, 0] = -2.67250597360800e-002;

            __statist_h_o_wts[5, 1] = 3.51893604312449e-002;

            __statist_h_o_wts[5, 2] = -4.05974425282616e-002;

            __statist_h_o_wts[5, 3] = -1.60131556662082e-001;

            __statist_h_o_wts[5, 4] = -1.10894806628259e-001;

            __statist_h_o_wts[5, 5] = 1.41837137168268e-002;

            __statist_h_o_wts[5, 6] = 1.08112986346109e-001;

            __statist_h_o_wts[5, 7] = -6.64571206218977e-002;

            __statist_h_o_wts[5, 8] = 1.30798792099661e-002;

            __statist_h_o_wts[5, 9] = -4.92605635246045e-002;

            __statist_h_o_wts[5, 10] = -1.76318520264406e-002;

            __statist_h_o_wts[5, 11] = 7.76144377162155e-002;

            __statist_h_o_wts[5, 12] = -3.08567747031166e-001;

            __statist_h_o_wts[5, 13] = -5.50884774995295e-005;

            __statist_h_o_wts[5, 14] = -1.50363718740452e-002;

            __statist_h_o_wts[5, 15] = 6.41264553548996e-002;

            __statist_h_o_wts[5, 16] = 2.89978373103098e-004;



            double[] __statist_hidden_bias = new double[17];

            __statist_hidden_bias[0] = 1.95543034158447e-001;

            __statist_hidden_bias[1] = -3.84019658561300e-001;

            __statist_hidden_bias[2] = 4.32807418727587e-001;

            __statist_hidden_bias[3] = -4.46421985508375e-001;

            __statist_hidden_bias[4] = -7.23575337093212e-001;

            __statist_hidden_bias[5] = 9.91235112114332e-002;

            __statist_hidden_bias[6] = 1.35663331048109e-001;

            __statist_hidden_bias[7] = 3.27028054375364e-001;

            __statist_hidden_bias[8] = 5.21967882482099e-001;

            __statist_hidden_bias[9] = 4.12735332595268e-001;

            __statist_hidden_bias[10] = -5.87540388880819e-001;

            __statist_hidden_bias[11] = 2.05884993452872e-001;

            __statist_hidden_bias[12] = 3.88809530333541e-001;

            __statist_hidden_bias[13] = 8.36610271219814e-002;

            __statist_hidden_bias[14] = -9.18636048355521e-002;

            __statist_hidden_bias[15] = 2.95130027843246e-001;

            __statist_hidden_bias[16] = -3.75153145187430e-001;



            double[] __statist_output_bias = new double[6];

            __statist_output_bias[0] = 9.04058667947959e-001;

            __statist_output_bias[1] = -4.89176400572412e-001;

            __statist_output_bias[2] = 8.59044896307259e-001;

            __statist_output_bias[3] = -1.09730315398094e+000;

            __statist_output_bias[4] = 1.15692251008572e+000;

            __statist_output_bias[5] = 6.25079545763874e-002;



            double[] __statist_inputs = new double[23];



            double[] __statist_hidden = new double[17];



            double[] __statist_outputs = new double[6];

            __statist_outputs[0] = -1.0e+307;

            __statist_outputs[1] = -1.0e+307;

            __statist_outputs[2] = -1.0e+307;

            __statist_outputs[3] = -1.0e+307;

            __statist_outputs[4] = -1.0e+307;

            __statist_outputs[5] = -1.0e+307;



            __statist_inputs[0] = XCMH;



            if (PCKBCA == "0-49")

            {

                __statist_inputs[1] = 1;

            }

            else

            {

                __statist_inputs[1] = 0;

            }



            if (PCKBCA == "100")

            {

                __statist_inputs[2] = 1;

            }

            else

            {

                __statist_inputs[2] = 0;

            }



            if (PCKBCA == "50-69")

            {

                __statist_inputs[3] = 1;

            }

            else

            {

                __statist_inputs[3] = 0;

            }



            if (PCKBCA == "70-89")

            {

                __statist_inputs[4] = 1;

            }

            else

            {

                __statist_inputs[4] = 0;

            }



            if (PCKBCA == "90-99")

            {

                __statist_inputs[5] = 1;

            }

            else

            {

                __statist_inputs[5] = 0;

            }



            if (PCKBCA == "с/п ТБА")

            {

                __statist_inputs[6] = 1;

            }

            else

            {

                __statist_inputs[6] = 0;

            }



            if (KBOCA == "0")

            {

                __statist_inputs[7] = 1;

            }

            else

            {

                __statist_inputs[7] = 0;

            }



            if (KBOCA == "1")

            {

                __statist_inputs[8] = 1;

            }

            else

            {

                __statist_inputs[8] = 0;

            }



            if (KBOCA == "2")

            {

                __statist_inputs[9] = 1;

            }

            else

            {

                __statist_inputs[9] = 0;

            }



            if (CCBCA == "0")

            {

                __statist_inputs[10] = 1;

            }

            else

            {

                __statist_inputs[10] = 0;

            }



            if (CCBCA == "1")

            {

                __statist_inputs[11] = 1;

            }

            else

            {

                __statist_inputs[11] = 0;

            }



            if (ONMK == "0")

            {

                __statist_inputs[12] = 1;

            }

            else

            {

                __statist_inputs[12] = 0;

            }



            if (ONMK == "1")

            {

                __statist_inputs[13] = 1;

            }

            else

            {

                __statist_inputs[13] = 0;

            }



            if (ONMK == "2")

            {

                __statist_inputs[14] = 1;

            }

            else

            {

                __statist_inputs[14] = 0;

            }



            if (NYHA == "0")

            {

                __statist_inputs[15] = 1;

            }

            else

            {

                __statist_inputs[15] = 0;

            }



            if (NYHA == "2")

            {

                __statist_inputs[16] = 1;

            }

            else

            {

                __statist_inputs[16] = 0;

            }



            if (NYHA == "3")

            {

                __statist_inputs[17] = 1;

            }

            else

            {

                __statist_inputs[17] = 0;

            }



            if (NYHA == "4")

            {

                __statist_inputs[18] = 1;

            }

            else

            {

                __statist_inputs[18] = 0;

            }



            if (XOBL == "0")

            {

                __statist_inputs[19] = 1;

            }

            else

            {

                __statist_inputs[19] = 0;

            }



            if (XOBL == "1")

            {

                __statist_inputs[20] = 1;

            }

            else

            {

                __statist_inputs[20] = 0;

            }



            if (XOBL == "2")

            {

                __statist_inputs[21] = 1;

            }

            else

            {

                __statist_inputs[21] = 0;

            }



            if (XOBL == "3")

            {

                __statist_inputs[22] = 1;

            }

            else

            {

                __statist_inputs[22] = 0;

            }



            double __statist_delta = 0;

            double __statist_maximum = 1;

            double __statist_minimum = 0;

            int __statist_ncont_inputs = 1;



            /*scale continuous inputs*/

            for (int __statist_i = 0; __statist_i < __statist_ncont_inputs; __statist_i++)

            {

                __statist_delta = (__statist_maximum - __statist_minimum) / (__statist_max_input[__statist_i] - __statist_min_input[__statist_i]);

                __statist_inputs[__statist_i] = __statist_minimum - __statist_delta * __statist_min_input[__statist_i] + __statist_delta * __statist_inputs[__statist_i];

            }



            int __statist_ninputs = 23;

            int __statist_nhidden = 17;



            /*Compute feed forward signals from Input layer to hidden layer*/

            for (int __statist_row = 0; __statist_row < __statist_nhidden; __statist_row++)

            {

                __statist_hidden[__statist_row] = 0.0;

                for (int __statist_col = 0; __statist_col < __statist_ninputs; __statist_col++)

                {

                    __statist_hidden[__statist_row] = __statist_hidden[__statist_row] + (__statist_i_h_wts[__statist_row, __statist_col] * __statist_inputs[__statist_col]);

                }

                __statist_hidden[__statist_row] = __statist_hidden[__statist_row] + __statist_hidden_bias[__statist_row];

            }



            for (int __statist_row = 0; __statist_row < __statist_nhidden; __statist_row++)

            {

                if (__statist_hidden[__statist_row] > 100.0)

                {

                    __statist_hidden[__statist_row] = 1.0;

                }

                else

                {

                    if (__statist_hidden[__statist_row] < -100.0)

                    {

                        __statist_hidden[__statist_row] = -1.0;

                    }

                    else

                    {

                        __statist_hidden[__statist_row] = Math.Tanh(__statist_hidden[__statist_row]);

                    }

                }

            }



            int __statist_noutputs = 6;



            /*Compute feed forward signals from hidden layer to output layer*/

            for (int __statist_row2 = 0; __statist_row2 < __statist_noutputs; __statist_row2++)

            {

                __statist_outputs[__statist_row2] = 0.0;

                for (int __statist_col2 = 0; __statist_col2 < __statist_nhidden; __statist_col2++)

                {

                    __statist_outputs[__statist_row2] = __statist_outputs[__statist_row2] + (__statist_h_o_wts[__statist_row2, __statist_col2] * __statist_hidden[__statist_col2]);

                }

                __statist_outputs[__statist_row2] = __statist_outputs[__statist_row2] + __statist_output_bias[__statist_row2];

            }



            for (int __statist_row = 0; __statist_row < __statist_noutputs; __statist_row++)

            {

                if (__statist_outputs[__statist_row] > 100.0)

                {

                    __statist_outputs[__statist_row] = 1.0;

                }

                else

                {

                    if (__statist_outputs[__statist_row] < -100.0)

                    {

                        __statist_outputs[__statist_row] = -1.0;

                    }

                    else

                    {

                        __statist_outputs[__statist_row] = Math.Tanh(__statist_outputs[__statist_row]);

                    }

                }

            }





            double __statist_sum = 0.0;

            for (int __statist_ii = 0; __statist_ii < __statist_noutputs; __statist_ii++)

            {

                if (__statist_outputs[__statist_ii] > 100)

                {

                    __statist_outputs[__statist_ii] = 1.0;

                  double  __statist_jj = __statist_ii;

                    for (int __statist_kk = 0; __statist_kk < __statist_noutputs; __statist_kk++)

                    {

                        if (__statist_kk != __statist_jj)

                        {

                            __statist_outputs[__statist_kk] = 0.0;

                        }

                    }

                }

                else

                {

                    __statist_outputs[__statist_ii] = Math.Exp(__statist_outputs[__statist_ii]);

                }

            }



            for (int __statist_ii = 0; __statist_ii < __statist_noutputs; __statist_ii++)

            {

                __statist_sum = __statist_sum + __statist_outputs[__statist_ii];

            }



            for (int __statist_ii = 0; __statist_ii < __statist_noutputs; __statist_ii++)

            {

                if (__statist_sum > 0)

                {

                    __statist_outputs[__statist_ii] = __statist_outputs[__statist_ii] / __statist_sum;

                }

            }





            int __statist_PredIndex = 1;

            for (int __statist_ii = 0; __statist_ii < __statist_noutputs; __statist_ii++)

            {

                if (__statist_ConfLevel < __statist_outputs[__statist_ii])

                {

                    __statist_ConfLevel = __statist_outputs[__statist_ii];

                    __statist_PredIndex = __statist_ii;

                }

            }



            return __statist_PredCat = __statist_DCats[__statist_PredIndex];



        }


    }
}
