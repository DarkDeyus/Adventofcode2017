using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Adventofcode2017
{
    //class Advent
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Which day do you want to see?");
    //        switch(Console.ReadLine())
    //        {

    //        }

    //    }
    //}

    class Day_1
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 1, part 1: \n\nTest inputs: \n");

            Day1 test = new Day1("1122");
            System.Console.WriteLine(test.Solve() + ", should be 3");
            Day1 test2 = new Day1("1111");
            System.Console.WriteLine(test2.Solve() + ", should be 4");
            Day1 test3 = new Day1("1234");
            System.Console.WriteLine(test3.Solve() + ", should be 0");
            Day1 test4 = new Day1("91212129");
            System.Console.WriteLine(test4.Solve() + ", should be 9");

            System.Console.WriteLine("\nSolution:\n");

            Day1 solution = new Day1("21752342814933766938172121674976879111362417653261522357855816893656462449168377359285244818489723869987861247912289729579296691684761143544956991583942215236568961875851755854977946147178746464675227699149925227227137557479769948569788884399379821111382536722699575759474473273939756348992714667963596189765734743169489599125771443348193383566159843593541134749392569865481578359825844394454173219857919349341442148282229689541561169341622222354651397342928678496478671339383923769856425795211323673389723181967933933832711545885653952861879231537976292517866354812943192728263269524735698423336673735158993853556148833861327959262254756647827739145283577793481526768156921138428318939361859721778556264519643435871835744859243167227889562738712953651128317624673985213525897522378259178625416722152155728615936587369515254936828668564857283226439881266871945998796488472249182538883354186573925183152663862683995449671663285775397453876262722567452435914777363522817594741946638986571793655889466419895996924122915777224499481496837343194149123735355268151941712871245863553836953349887831949788869852929147849489265325843934669999391846286319268686789372513976522282587526866148166337215961493536262851512218794139272361292811529888161198799297966893366553115353639298256788819385272471187213579185523521341651117947676785341146235441411441813242514813227821843819424619974979886871646621918865274574538951761567855845681272364646138584716333599843835167373525248547542442942583122624534494442516259616973235858469131159773167334953658673271599748942956981954699444528689628848694446818825465485122869742839711471129862632128635779658365756362863627135983617613332849756371986376967117549251566281992964573929655589313871976556784849231916513831538254812347116253949818633527185174221565279775766742262687713114114344843534958833372634182176866315441583887177759222598853735114191874277711434653854816841589229914164681364497429324463193669337827467661773833517841763711156376147664749175267212562321567728575765844893232718971471289841171642868948852136818661741238178676857381583155547755219837116125995361896562498721571413742");
            System.Console.WriteLine("Solution : " + solution.Solve());

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 2, Part 2: \n\nTest inputs: \n");

            Day1 newtest = new Day1("1212");
            System.Console.WriteLine(newtest.newSolve() + ", should be 6");
            Day1 newtest2 = new Day1("1221");
            System.Console.WriteLine(newtest2.newSolve() + ", should be 0");
            Day1 newtest3 = new Day1("123425");
            System.Console.WriteLine(newtest3.newSolve() + ", should be 4");
            Day1 newtest4 = new Day1("123123");
            System.Console.WriteLine(newtest4.newSolve() + ", should be 12");
            Day1 newtest5 = new Day1("12131415");
            System.Console.WriteLine(newtest5.newSolve() + ", should be 4");

            System.Console.WriteLine("\nSolution:\n");

            Day1 newsolution = new Day1("21752342814933766938172121674976879111362417653261522357855816893656462449168377359285244818489723869987861247912289729579296691684761143544956991583942215236568961875851755854977946147178746464675227699149925227227137557479769948569788884399379821111382536722699575759474473273939756348992714667963596189765734743169489599125771443348193383566159843593541134749392569865481578359825844394454173219857919349341442148282229689541561169341622222354651397342928678496478671339383923769856425795211323673389723181967933933832711545885653952861879231537976292517866354812943192728263269524735698423336673735158993853556148833861327959262254756647827739145283577793481526768156921138428318939361859721778556264519643435871835744859243167227889562738712953651128317624673985213525897522378259178625416722152155728615936587369515254936828668564857283226439881266871945998796488472249182538883354186573925183152663862683995449671663285775397453876262722567452435914777363522817594741946638986571793655889466419895996924122915777224499481496837343194149123735355268151941712871245863553836953349887831949788869852929147849489265325843934669999391846286319268686789372513976522282587526866148166337215961493536262851512218794139272361292811529888161198799297966893366553115353639298256788819385272471187213579185523521341651117947676785341146235441411441813242514813227821843819424619974979886871646621918865274574538951761567855845681272364646138584716333599843835167373525248547542442942583122624534494442516259616973235858469131159773167334953658673271599748942956981954699444528689628848694446818825465485122869742839711471129862632128635779658365756362863627135983617613332849756371986376967117549251566281992964573929655589313871976556784849231916513831538254812347116253949818633527185174221565279775766742262687713114114344843534958833372634182176866315441583887177759222598853735114191874277711434653854816841589229914164681364497429324463193669337827467661773833517841763711156376147664749175267212562321567728575765844893232718971471289841171642868948852136818661741238178676857381583155547755219837116125995361896562498721571413742");
            System.Console.WriteLine("Solution : " + newsolution.newSolve() + "\n");
        }
    }

    class Day_2
    {
        static void Main(string[] args)
        {
            String input = File.ReadAllText(@".\Day2.txt");
            int i = 0, j = 0;
            int[,] result = new int[16, 16];
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    result[i, j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }


            System.Console.WriteLine("Day 2, part 1: \n\nTest inputs: \n");

            int[][] tab1 = new[] { new[] { 5, 1, 9, 5 }, new[] { 7, 5, 3 }, new[] { 2, 4, 6, 8 } };
            Day2 test = new Day2(tab1);
            System.Console.WriteLine(test.checksum() + " , should be 18");

            int[,] tab2 = { { 1, 2, -1 }, { 3, 4, 0 }, { 0, 5, 2 } };
            Day2 test2 = new Day2(tab2);
            System.Console.WriteLine(test2.checksum() + " , should be 12");

            System.Console.WriteLine("\nSolution:\n");


            Day2 solution = new Day2(result);
            System.Console.WriteLine("Solution: " + solution.checksum());

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 2, Part 2: \n\nTest inputs: \n");

            int[,] tab3 = { { 5, 9, 2, 8 }, { 9, 4, 7, 3 }, { 3, 8, 6, 5 } };
            Day2 newtest = new Day2(tab3);
            System.Console.WriteLine(newtest.newchecksum() + " , should be 9");

            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("Solution: " + solution.newchecksum() + "\n");
        }
    }

    class Day_3
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 3, part 1: \n\nTest inputs: \n");

            Day3 test = new Day3(1);
            System.Console.WriteLine(test.calculateDistance() + " , should be 0");

            Day3 test1 = new Day3(12);
            System.Console.WriteLine(test1.calculateDistance() + " , should be 3");

            Day3 test2 = new Day3(23);
            System.Console.WriteLine(test2.calculateDistance() + " , should be 2");

            Day3 test3 = new Day3(1024);
            System.Console.WriteLine(test3.calculateDistance() + " , should be 31");



            System.Console.WriteLine("\nSolution:\n");

            Day3 solution = new Day3(325489);
            System.Console.WriteLine("Solution: " + solution.calculateDistance());

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 3, Part 2: \n\nTest inputs: \n");

            System.Console.WriteLine(test1.newcalculateDistance() + " , should be 23");


            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("Solution: " + solution.newcalculateDistance());

        }
    }

    class Day_4
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Day 4, part 1: \n\nTest inputs: \n");

            Day4 test = new Day4("Ala ma kota");
            System.Console.WriteLine(test.check() + " , should be 1");

            Day4 test1 = new Day4("ynsocz vid rfmsy essqt fpbjvvq sldje essqt");
            System.Console.WriteLine(test1.check() + " , should be 0");

            System.Console.WriteLine("\nSolution:\n");

            Day4 solution = new Day4(@".\Day4.txt", 1);

            System.Console.WriteLine("solution: " + solution.check());


            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 4, Part 2: \n\nTest inputs: \n");

            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("solution: " + solution.checkanagrams() + "\n");

        }
    }

    class Day_5
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 5, part 1: \n\nTest inputs: \n");

            Day5 test = new Day5("0 3 0 1 -3");
            System.Console.WriteLine(test.checkloop() + " , powinno byc 5");

            System.Console.WriteLine("\nSolution:\n");

            Day5 solution = new Day5("2 0 0 1 2 0 1 -4 -5 0 -1 0 -6 0 -5 2 -9 -11 -15 -3 -11 -12 -14 -5 -16 -3 -13 -6 0 -3 -17 0 -17 -5 -1 -26 -21 -14 -20 -7 -24 -26 -32 -41 -2 -18 -18 -13 -28 0 -32 -3 -2 -14 -17 -54 -22 -34 -33 -34 0 -46 -3 -44 -58 -10 -56 -65 -46 -24 -20 -4 -27 -41 -33 -31 -20 -75 -73 -41 -36 -31 -70 -46 -1 -79 -61 -51 -77 -44 -55 -2 -18 -26 -50 -79 -59 -69 -62 -80 -13 -69 -97 -71 -24 -7 -40 -10 -23 -85 -97 -103 -55 -90 -40 -60 -98 -95 -39 -76 -63 -12 -2 -65 -109 -47 -12 -37 -5 -23 -125 -124 -49 -91 -70 -134 -54 -122 -135 -12 -23 -22 -83 -40 -133 -77 -88 -119 -146 -26 -12 -108 -63 -111 -148 -99 -77 -77 -76 -89 -37 -95 -105 -76 -137 -151 -146 -141 -162 -12 -68 -36 -116 -60 -73 -61 -60 -101 -168 -142 -143 -118 -165 -108 -179 -180 -11 -152 -67 -33 -10 -169 -155 -16 -136 -165 -164 2 1 -28 -131 -86 -153 -116 -113 -149 -66 -64 -36 -168 -116 -159 -15 -180 -125 -146 -135 -105 -161 -133 -207 -192 -192 -99 -146 -93 -21 -5 -189 -86 -16 -4 -44 -167 -20 -201 -110 -103 -223 -182 -71 -194 -68 -90 -237 -147 2 -88 -184 -90 -12 -119 -85 -138 -179 -152 -158 -82 -122 -179 -191 -120 -174 -165 -137 -181 -58 -250 -66 -194 -202 -171 -179 -137 -250 -248 -167 -108 -27 -175 -34 -254 -35 -157 -158 -31 -52 -236 -238 -247 -279 -209 -257 -167 -151 -7 -182 -2 -149 -87 -245 -141 -238 -186 -71 -97 -128 -147 -52 -93 -142 -197 -296 -73 -89 -14 -253 -190 -295 -312 -47 -236 -233 -238 -305 -121 -191 -251 -91 -307 -77 -228 -300 -197 -91 -191 -299 -77 -255 -51 -232 -64 -198 -187 -96 -86 -203 -216 -203 -343 -203 -78 -99 -174 -269 -349 -173 -52 -233 -154 -151 -304 -70 -235 -106 -226 -325 -142 -192 -115 -170 -15 -35 -174 -267 -108 -374 -128 -60 -131 -364 -371 -56 -96 -365 -305 -140 -50 -220 -179 -43 -356 -120 -216 -276 -103 -389 -28 -393 -341 -74 -85 -361 -68 -111 -4 -216 -263 -115 -194 -382 -285 -176 -145 -24 -59 -291 -170 -358 -226 -355 -292 -185 -297 -156 -248 -332 -319 -311 -46 -170 -428 -222 -35 -136 -206 -81 -330 -89 -75 -248 -42 -52 -24 -39 -129 -228 -242 -396 -222 -433 -168 -362 -4 -345 -395 -435 -14 -439 -136 -267 -417 -107 -177 -8 -208 -219 -222 -453 -155 -183 -252 0 -173 -71 -164 -187 -80 -292 -246 -89 -217 -227 -93 -244 -82 -51 -23 -283 -261 -50 -384 -415 -149 -103 -481 -404 -267 -80 -61 -130 -228 -310 -319 -186 -88 -173 -40 -69 -231 -398 -342 -176 -33 -304 -232 -220 -381 -436 -74 -116 -398 -467 -341 -483 -137 -5 -437 -67 -296 -137 -166 -216 -192 -307 -68 -319 -296 -524 -308 -68 -21 -515 -531 -221 -173 -261 -200 -450 -95 -366 -14 -29 -23 -173 -397 -373 -283 -104 -246 -153 -240 -378 -306 -495 -518 -459 -459 -340 -475 -96 -347 -8 -365 -7 -482 -113 -223 -313 -456 -89 -205 -507 -538 -115 -310 -484 -96 -367 -582 -32 -550 -247 -257 -479 -165 -346 -514 -188 -180 -506 -117 -92 -128 -507 -387 -52 -535 -210 -221 -560 -245 -70 -552 -99 -529 -607 -263 -345 -253 -426 -351 -92 -489 -478 -226 -606 -287 -277 -432 -336 -418 -94 -2 -192 -600 -454 -26 -3 -630 -294 -105 -439 -589 -425 -623 -451 -487 -117 -538 -78 -126 -485 -326 -455 -370 -389 -379 -158 -441 -524 -435 -160 -198 -172 -313 -380 -128 -166 -562 -427 -23 -616 -95 -188 -417 -419 -589 -488 -377 -520 -412 -348 -359 -488 -108 -409 -56 -460 -364 -233 -352 -59 -313 -609 -534 -432 -104 -514 -68 -83 -305 -308 -645 -535 -624 -453 -630 -274 -98 -280 -38 -443 -620 -411 -624 -379 -373 -338 -410 -382 -171 -645 -430 -294 -696 -513 -659 -690 -558 -2 -325 -234 -437 -610 -158 -186 -539 -405 -78 -100 -311 -201 -558 -604 -386 -457 -125 -419 -680 -147 -237 -107 -155 -550 -565 -214 -528 -353 -637 -6 -634 -332 -92 -474 -289 -617 -141 -398 -367 -537 -369 -88 -608 -699 -257 -602 -276 -406 -92 -746 -398 -387 -234 -331 -225 -480 -667 -264 -299 -673 -265 -142 -512 -573 -508 -551 -471 -270 -328 -648 -625 -779 -232 -393 -749 -84 -240 -59 -220 -55 -224 -350 -130 -23 -239 -105 -2 -762 -702 -163 -94 -350 -11 -176 -43 -654 -136 -348 -215 -67 -599 -757 -636 -367 -61 -209 -623 -342 -111 -93 -14 -613 -362 -837 -734 -468 -803 -548 -699 -744 -429 -243 -633 -382 -780 -668 -498 -664 -539 -781 -525 -697 -715 -126 -276 -504 -175 -592 -688 -92 -548 -298 -33 -532 -674 -57 -531 -488 -310 -90 -757 -496 -132 -733 -701 -61 -797 -215 -319 -700 -295 -572 -41 -140 -176 -479 -560 -164 -338 -794 -132 -453 -709 -445 -802 2 -336 -562 -802 -878 -547 -368 -502 -574 -275 -687 -560 -432 -423 -174 -367 -59 -605 -340 -626 -142 -601 -488 -299 -466 -521 -783 -140 -731 -779 -252 -663 -906 -410 -601 -524 -332 -750 -556 -730 -749 -294 -798 -93 -345 -316 -186 -634 -904 -237 -134 -765 -953 -170 -854 -910 -99 -782 -564 -505 -49 -827 -64 -297 -548 -841 -598 -414 -184 -67 -99 -880 -855 -722 -725 -582 -416 -473 -339 -491 -162 -311 -43 -938 -608 -524 -212 -4 -945 -544 -879 -382 -21 -512 -169 -284 -140 -588 -407 -56 -610 -75 -412 -321 -801 -881 -220 -388 -116 -962 -1007 -862 -20 -409 -116 -943 -558 -1001 -548 -302 -165 -730 -1012 -669 -875 -393 -979");
            System.Console.WriteLine("Solution: " + solution.checkloop());

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 5, Part 2: \n\nTest inputs: \n");

            System.Console.WriteLine(test.newcheckloop() + " , powinno byc 10");

            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("Solution: " + solution.newcheckloop() + "\n");

        }
    }

    class Day_6
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 6, part 1: \n\nTest inputs: \n");

            Day6 test = new Day6("0 2 7 0");

            System.Console.WriteLine(test.distribute() + ", should be 5");

            System.Console.WriteLine("\nSolution:\n");

            Day6 solution = new Day6("10 3 15 10 5 15 5 15 9 2 5 8 5 2 3 6");

            System.Console.WriteLine("Solution: " + solution.distribute());

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 6, Part 2: \n\nTest inputs: \n");

            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("Solution: " + solution.newdistribute());

        }
    }

    class Day_7
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 7, part 1: \n\nTest inputs: \n");

            Day7 test = new Day7("Day7_test.txt");
            System.Console.WriteLine(test.FindBottom() + " , should be tknk");

            System.Console.WriteLine("\nSolution:\n");

            Day7 solution = new Day7("Day7.txt");
            System.Console.WriteLine("Solution: " + solution.FindBottom());


            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 7, Part 2: \n\nTest inputs: \n");

            System.Console.WriteLine(test.Balance() + " , should be 60");

            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("Solution: " + solution.Balance());





        }
    }

    class Day_8
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 8, part 1: \n\nTest inputs: \n");

            Day8 test = new Day8("Day8_test.txt");
            System.Console.WriteLine(test.ExecuteCommands() + " , should be 1");
            System.Console.WriteLine("\nSolution:\n");

            Day8 solution = new Day8("Day8.txt");
            System.Console.WriteLine("Solution: " + solution.ExecuteCommands());

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 8, Part 2: \n\nTest inputs: \n");

            System.Console.WriteLine(test.FindMax() + " , should be 10");

            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("Solution: " + solution.FindMax());

        }
    }

    class Day_9
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 9, part 1: \n\nTest inputs: \n");

            Day9 test = new Day9("{}");
            System.Console.WriteLine(test.Calculate() + " ,should be 1");

            Day9 test1 = new Day9("{ {{ } }}");
            System.Console.WriteLine(test1.Calculate() + " ,should be 6");

            Day9 test2 = new Day9("{{{},{},{{}}}}");
            System.Console.WriteLine(test2.Calculate() + " ,should be 16");

            Day9 test3 = new Day9("{<a>,<a>,<a>,<a>}");
            System.Console.WriteLine(test3.Calculate() + " ,should be 1");

            Day9 test4 = new Day9("{{<ab>},{<ab>},{<ab>},{<ab>}}");
            System.Console.WriteLine(test4.Calculate() + " ,should be 9");

            Day9 test5 = new Day9("{{<a!>},{<a!>},{<a!>},{<ab>}}");
            System.Console.WriteLine(test5.Calculate() + " ,should be 3");

            Day9 test6 = new Day9("{{<!!>},{<!!>},{<!!>},{<!!>}}");
            System.Console.WriteLine(test6.Calculate() + " ,should be 9");

            System.Console.WriteLine("\nSolution:\n");
            Day9 solution = new Day9("Day9.txt", 1);
            System.Console.WriteLine("Solution: " + solution.Calculate());

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 9, Part 2: \n\nTest inputs: \n");

            Day9 newtest = new Day9("<random characters>");
            System.Console.WriteLine(newtest.Garbageammount() + " ,should be 17");

            Day9 newtest1 = new Day9("<<<<>");
            System.Console.WriteLine(newtest1.Garbageammount() + " ,should be 3");

            Day9 newtest2 = new Day9("<{!>}>");
            System.Console.WriteLine(newtest2.Garbageammount() + " ,should be 2");

            Day9 newtest3 = new Day9("<!!!>>");
            System.Console.WriteLine(newtest3.Garbageammount() + " ,should be 0");

            Day9 newtest4 = new Day9("<{oai!a,<{i<a>");
            System.Console.WriteLine(newtest4.Garbageammount() + " ,should be 10");

            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("Solution: " + solution.Garbageammount());


        }
    }

    class Day_10
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 10, part 1: \n\nTest inputs: \n");

            Day10 test = new Day10(4);
            System.Console.WriteLine(test.KnotHash("3, 4, 1, 5") + " , should be 12");
            System.Console.WriteLine("\nSolution:\n");

            Day10 solution = new Day10(255);
            System.Console.WriteLine("Solution: " + solution.KnotHash("31,2,85,1,80,109,35,63,98,255,0,13,105,254,128,33"));

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 10, Part 2: \n\nTest inputs: \n");

            System.Console.WriteLine(solution.KnotHashHex("") + ", should be a2582a3a0e66e6e86e3812dcb672a272");
            System.Console.WriteLine(solution.KnotHashHex("AoC 2017") + ", should be 33efeb34ea91902bb2f59c9920caa6cd");
            System.Console.WriteLine(solution.KnotHashHex("1,2,3") + ", should be 3efbe78a8d82f29979031a4aa0b16a9d");
            System.Console.WriteLine(solution.KnotHashHex("1,2,4") + ", should be 63960835bcdc130f0b66d7ff4f6a5a8e");


            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("Solution: " + solution.KnotHashHex("31,2,85,1,80,109,35,63,98,255,0,13,105,254,128,33"));

        }
    }

    class Day_11
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 11, part 1: \n\nTest inputs: \n");

            Day11 test = new Day11("Day11_test.txt");
            Console.WriteLine(test.Return() + " ,powinno byc 3");

            System.Console.WriteLine("\nSolution:\n");

            Day11 solution = new Day11("Day11.txt");

            Console.WriteLine("Solution: " + solution.Return());


            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 11, Part 2: \n\nTest inputs: \n");

            Console.WriteLine(test.Findfurtest() + " , should be 3");

            System.Console.WriteLine("\nSolution:\n");

            Console.WriteLine("Solution: " + solution.Findfurtest());

        }
    }

    class Day_12
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 12, part 1: \n\nTest inputs: \n");

            Day12 test = new Day12("Day12_test.txt");

            System.Console.WriteLine(test.Numberofprograms(0) + " ,should be 6");

            System.Console.WriteLine("\nSolution:\n");

            Day12 solution = new Day12("Day12.txt");
            System.Console.WriteLine("Solution: " + solution.Numberofprograms(0));

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 12, Part 2: \n\nTest inputs: \n");

            System.Console.WriteLine(test.Numberofgroups() + " ,should be 2");

            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("Solution: " + solution.Numberofgroups());

        }
    }

    class Day_13
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 13, part 1: \n\nTest inputs: \n");

            Day13 test = new Day13("Day13_test.txt");
            System.Console.WriteLine(test.walk() + " ,should be 24");

            System.Console.WriteLine("\nSolution:\n");

            Day13 solution = new Day13("Day13.txt");
            Console.WriteLine("Solution: " + solution.walk());

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 13, Part 2: \n\nTest inputs: \n");

            System.Console.WriteLine(test.undetected() + " ,should be 10");

            System.Console.WriteLine("\nSolution:\n");

            Console.WriteLine("Solution: " + solution.undetected());
        }
    }

    class Day_14
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 14, part 1: \n\nTest inputs: \n");

            Day14 test = new Day14("flqrgnkx");
            Console.WriteLine(test.Calculatespace() + " , should be 8108");

            System.Console.WriteLine("\nSolution:\n");

            Day14 solution = new Day14("oundnydw");
            Console.WriteLine("Solution: " + solution.Calculatespace());

            System.Console.WriteLine("test");

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 5, Part 2: \n\nTest inputs: \n");



            System.Console.WriteLine("\nSolution:\n");

            Console.WriteLine("Solution: {0}", solution.Numberofregions());

        }
    }

    class Day_15
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 15, part 1: \n\nTest inputs: \n");

            Day15 test = new Day15(65, 8921, 16807, 48271, 2147483647);
            System.Console.WriteLine(test.Findpairs() + " , should be 588");

            System.Console.WriteLine("\nSolution:\n");

            Day15 solution = new Day15(703, 516, 16807, 48271, 2147483647);
            System.Console.WriteLine("Solution: {0}", solution.Findpairs());

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 15, Part 2: \n\nTest inputs: \n");

            System.Console.WriteLine("{0} , should be 309", test.Betterpairs());

            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("Solution: {0}", solution.Betterpairs());


        }
    }

    class Day_16
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 16, part 1: \n\nTest inputs: \n");

            Day16 test = new Day16(5);
            System.Console.WriteLine("{0} , should be baedc", test.Dance("Day16_test.txt"));

            System.Console.WriteLine("\nSolution:\n");

            Day16 solution = new Day16(16);
            System.Console.WriteLine("Solution: {0}", solution.Dance("Day16.txt"));

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 16, Part 2: \n\nTest inputs: \n");



            System.Console.WriteLine("\nSolution:\n");
            string[] test1 = { "a", "b", "c" };
            string[] test2 = { "a", "b", "c" };

            

             System.Console.WriteLine("Solution: {0}", solution.Billiondances("Day16.txt"));

        }
    }

    class Day_17
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 5, part 1: \n\nTest inputs: \n");

            System.Console.WriteLine("test");

            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("test");

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 5, Part 2: \n\nTest inputs: \n");



            System.Console.WriteLine("\nSolution:\n");



        }
    }

    class Day_18
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 18, part 1: \n\nTest inputs: \n");

            Day18 test = new Day18("Day18_test.txt");
            Console.WriteLine(" {0} , should be 4", test.Play());

            System.Console.WriteLine("\nSolution:\n");

            Day18 solution = new Day18("Day18.txt");

            System.Console.WriteLine("Solution: {0} ", solution.Play());

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 18, Part 2: \n\nTest inputs: \n");



            System.Console.WriteLine("\nSolution:\n");



        }
    }

    class Day_19
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 5, part 1: \n\nTest inputs: \n");

            System.Console.WriteLine("test");

            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("test");

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 5, Part 2: \n\nTest inputs: \n");



            System.Console.WriteLine("\nSolution:\n");



        }
    }

    class Day_20
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 5, part 1: \n\nTest inputs: \n");

            System.Console.WriteLine("test");

            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("test");

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 5, Part 2: \n\nTest inputs: \n");



            System.Console.WriteLine("\nSolution:\n");



        }
    }

    class Day_21
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 5, part 1: \n\nTest inputs: \n");

            System.Console.WriteLine("test");

            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("test");

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 5, Part 2: \n\nTest inputs: \n");



            System.Console.WriteLine("\nSolution:\n");



        }
    }

    class Day_22
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 5, part 1: \n\nTest inputs: \n");

            System.Console.WriteLine("test");

            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("test");

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 5, Part 2: \n\nTest inputs: \n");



            System.Console.WriteLine("\nSolution:\n");



        }
    }

    class Day_23
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 5, part 1: \n\nTest inputs: \n");

            System.Console.WriteLine("test");

            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("test");

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 5, Part 2: \n\nTest inputs: \n");



            System.Console.WriteLine("\nSolution:\n");



        }
    }

    class Day_24
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 5, part 1: \n\nTest inputs: \n");

            System.Console.WriteLine("test");

            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("test");

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 5, Part 2: \n\nTest inputs: \n");



            System.Console.WriteLine("\nSolution:\n");



        }
    }

    class Day_25
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Day 5, part 1: \n\nTest inputs: \n");

            System.Console.WriteLine("test");

            System.Console.WriteLine("\nSolution:\n");

            System.Console.WriteLine("test");

            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Day 5, Part 2: \n\nTest inputs: \n");



            System.Console.WriteLine("\nSolution:\n");



        }
    }


}
