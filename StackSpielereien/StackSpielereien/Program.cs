using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackSpielereien
{
    class Program
    {
        static void StringHatValueSemantics()
        {
            string a = "Banane";
            string b = a;
            a = "Kirsche";
            Console.WriteLine(b);
        }


        static void IntAufHeapMoeglich()
        {
            int i = new int();
            i = 5;
            int j = new int();
            j = i;
            i = 4711;

            Console.WriteLine(j);

            
        }

        static void EinIntArray()
        {
            int[] intArray = new int[10000];

            intArray[0] = 1;
            intArray[1] = 2;
            intArray[2] = 3;
            intArray[3] = 4;
            intArray[4] = 5;
            intArray[5] = 6;
            intArray[6] = 7;
            intArray[7] = 8;
            intArray[8] = 9;
            intArray[9] = 10;
            intArray[10] = 11;
            intArray[11] = 12;
            intArray[12] = 13;
            intArray[13] = 14;
            intArray[14] = 15;
            intArray[15] = 16;
            intArray[16] = 17;
            intArray[17] = 18;
            intArray[18] = 19;
            intArray[19] = 20;
            intArray[20] = 21;
            intArray[21] = 22;
            intArray[22] = 23;
            intArray[23] = 24;
            intArray[24] = 25;
            intArray[25] = 26;
            intArray[26] = 27;
            intArray[27] = 28;
            intArray[28] = 29;
            intArray[29] = 30;
            intArray[30] = 31;
            intArray[31] = 32;
            intArray[32] = 33;
            intArray[33] = 34;
            intArray[34] = 35;
            intArray[35] = 36;
            intArray[36] = 37;
            intArray[37] = 38;
            intArray[38] = 39;
            intArray[39] = 40;
            intArray[40] = 41;
            intArray[41] = 42;
            intArray[42] = 43;
            intArray[43] = 44;
            intArray[44] = 45;
            intArray[45] = 46;
            intArray[46] = 47;
            intArray[47] = 48;
            intArray[48] = 49;
            intArray[49] = 50;
            intArray[50] = 51;
            intArray[51] = 52;
            intArray[52] = 53;
            intArray[53] = 54;
            intArray[54] = 55;
            intArray[55] = 56;
            intArray[56] = 57;
            intArray[57] = 58;
            intArray[58] = 59;
            intArray[59] = 60;
            intArray[60] = 61;
            intArray[61] = 62;
            intArray[62] = 63;
            intArray[63] = 64;
            intArray[64] = 65;
            intArray[65] = 66;
            intArray[66] = 67;
            intArray[67] = 68;
            intArray[68] = 69;
            intArray[69] = 70;
            intArray[70] = 71;
            intArray[71] = 72;
            intArray[72] = 73;
            intArray[73] = 74;
            intArray[74] = 75;
            intArray[75] = 76;
            intArray[76] = 77;
            intArray[77] = 78;
            intArray[78] = 79;
            intArray[79] = 80;
            intArray[80] = 81;
            intArray[81] = 82;
            intArray[82] = 83;
            intArray[83] = 84;
            intArray[84] = 85;
            intArray[85] = 86;
            intArray[86] = 87;
            intArray[87] = 88;
            intArray[88] = 89;
            intArray[89] = 90;
            intArray[90] = 91;
            intArray[91] = 92;
            intArray[92] = 93;
            intArray[93] = 94;
            intArray[94] = 95;
            intArray[95] = 96;
            intArray[96] = 97;
            intArray[97] = 98;
            intArray[98] = 99;
            intArray[99] = 100;

            Console.WriteLine("Array mit " + intArray.Length + " angelegt.");
            Console.ReadKey();

        }

        static void VieleInt()
        {
            int int1 = 1;
            int int2 = 2;
            int int3 = 3;
            int int4 = 4;
            int int5 = 5;
            int int6 = 6;
            int int7 = 7;
            int int8 = 8;
            int int9 = 9;
            int int10 = 10;
            int int11 = 11;
            int int12 = 12;
            int int13 = 13;
            int int14 = 14;
            int int15 = 15;
            int int16 = 16;
            int int17 = 17;
            int int18 = 18;
            int int19 = 19;
            int int20 = 20;
            int int21 = 21;
            int int22 = 22;
            int int23 = 23;
            int int24 = 24;
            int int25 = 25;
            int int26 = 26;
            int int27 = 27;
            int int28 = 28;
            int int29 = 29;
            int int30 = 30;
            int int31 = 31;
            int int32 = 32;
            int int33 = 33;
            int int34 = 34;
            int int35 = 35;
            int int36 = 36;
            int int37 = 37;
            int int38 = 38;
            int int39 = 39;
            int int40 = 40;
            int int41 = 41;
            int int42 = 42;
            int int43 = 43;
            int int44 = 44;
            int int45 = 45;
            int int46 = 46;
            int int47 = 47;
            int int48 = 48;
            int int49 = 49;
            int int50 = 50;
            int int51 = 51;
            int int52 = 52;
            int int53 = 53;
            int int54 = 54;
            int int55 = 55;
            int int56 = 56;
            int int57 = 57;
            int int58 = 58;
            int int59 = 59;
            int int60 = 60;
            int int61 = 61;
            int int62 = 62;
            int int63 = 63;
            int int64 = 64;
            int int65 = 65;
            int int66 = 66;
            int int67 = 67;
            int int68 = 68;
            int int69 = 69;
            int int70 = 70;
            int int71 = 71;
            int int72 = 72;
            int int73 = 73;
            int int74 = 74;
            int int75 = 75;
            int int76 = 76;
            int int77 = 77;
            int int78 = 78;
            int int79 = 79;
            int int80 = 80;
            int int81 = 81;
            int int82 = 82;
            int int83 = 83;
            int int84 = 84;
            int int85 = 85;
            int int86 = 86;
            int int87 = 87;
            int int88 = 88;
            int int89 = 89;
            int int90 = 90;
            int int91 = 91;
            int int92 = 92;
            int int93 = 93;
            int int94 = 94;
            int int95 = 95;
            int int96 = 96;
            int int97 = 97;
            int int98 = 98;
            int int99 = 99;
            int int100 = 100;

            Console.WriteLine("Viele Ints angelegt.");
            Console.ReadKey();

        }
        static void Main(string[] args)
        {

            //StringHatValueSemantics();
            //VieleInt();
            EinIntArray();
            Console.ReadKey();
        }
    }
}
