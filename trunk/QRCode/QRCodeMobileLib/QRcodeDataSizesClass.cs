using System;

using System.Collections.Generic;
using System.Text;

namespace QRCode
{
    public static class QRcodeDataSizesClass
    {
        // Version	Modules	ECCLevel	Databits	Numeric	Alfanumeric	Binary	Kanji
        public static class DataSizes
        {
                // Version	Modules	ECCLevel	Databits	Numeric	Alfanumeric	Binary	Kanji
            public static level[] levels = new level[]{
                new level(1, "21x21", "L", 152, 41, 25, 17, 10),
                new level(1, "21x21", "M", 128, 34, 20, 14, 8),
                new level(1, "21x21", "Q", 104, 27, 16, 11, 7),
                new level(1, "21x21", "H", 72, 17, 10, 7, 4),
                new level(2, "25x25", "L", 272, 77, 47, 32, 20),
                new level(2, "25x25", "M", 224, 63, 38, 26, 16),
                new level(2, "25x25", "Q", 176, 48, 29, 20, 12),
                new level(2, "25x25", "H", 128, 34, 20, 14, 8),
                new level(3, "29x29", "L", 440, 127, 77, 53, 32),
                new level(3, "29x29", "M", 352, 101, 61, 42, 26),
                new level(3, "29x29", "Q", 272, 77, 47, 32, 20),
                new level(3, "29x29", "H", 208, 58, 35, 24, 15),
                new level(4, "33x33", "L", 640, 187, 114, 78, 48),
                new level(4, "33x33", "M", 512, 149, 90, 62, 38),
                new level(4, "33x33", "Q", 384, 111, 67, 46, 28),
                new level(4, "33x33", "H", 288, 82, 50, 34, 21),
                new level(5, "37x37", "L", 864, 255, 154, 106, 65),
                new level(5, "37x37", "M", 688, 202, 122, 84, 52),
                new level(5, "37x37", "Q", 496, 144, 87, 60, 37),
                new level(5, "37x37", "H", 368, 106, 64, 44, 27),
                new level(6, "41x41", "L", 1088, 322, 195, 134, 82),
                new level(6, "41x41", "M", 864, 255, 154, 106, 65),
                new level(6, "41x41", "Q", 608, 178, 108, 74, 45),
                new level(6, "41x41", "H", 480, 139, 84, 58, 36),
                new level(7, "45x45", "L", 1248, 370, 224, 154, 95),
                new level(7, "45x45", "M", 992, 293, 178, 122, 75),
                new level(7, "45x45", "Q", 704, 207, 125, 86, 53),
                new level(7, "45x45", "H", 528, 154, 93, 64, 39),
                new level(8, "49x49", "L", 1552, 461, 279, 192, 118),
                new level(8, "49x49", "M", 1232, 365, 221, 152, 93),
                new level(8, "49x49", "Q", 880, 259, 157, 108, 66),
                new level(8, "49x49", "H", 688, 202, 122, 84, 52),
                new level(9, "53x53", "L", 1856, 552, 335, 230, 141),
                new level(9, "53x53", "M", 1456, 432, 262, 180, 111),
                new level(9, "53x53", "Q", 1056, 312, 189, 130, 80),
                new level(9, "53x53", "H", 800, 235, 143, 98, 60),
                new level(10, "57x57", "L", 2192, 652, 395, 271, 167),
                new level(10, "57x57", "M", 1728, 513, 311, 213, 131),
                new level(10, "57x57", "Q", 1232, 364, 221, 151, 93),
                new level(10, "57x57", "H", 976, 288, 174, 119, 74),
                new level(11, "61x61", "L", 2592, 772, 468, 321, 198),
                new level(11, "61x61", "M", 2032, 604, 366, 251, 155),
                new level(11, "61x61", "Q", 144, 427, 259, 177, 109),
                new level(11, "61x61", "H", 112, 331, 200, 137, 85),
                new level(12, "65x65", "L", 296, 883, 535, 367, 226),
                new level(12, "65x65", "M", 232, 691, 419, 287, 177),
                new level(12, "65x65", "Q", 1648, 489, 296, 203, 125),
                new level(12, "65x65", "H", 1264, 374, 227, 155, 96),
                new level(13, "69x69", "L", 3424, 1022, 619, 425, 262),
                new level(13, "69x69", "M", 2672, 796, 483, 331, 204),
                new level(13, "69x69", "Q", 1952, 580, 352, 241, 149),
                new level(13, "69x69", "H", 144, 427, 259, 177, 109),
                new level(14, "73x73", "L", 3688, 1101, 667, 458, 282),
                new level(14, "73x73", "M", 292, 871, 528, 362, 223),
                new level(14, "73x73", "Q", 2088, 621, 376, 258, 159),
                new level(14, "73x73", "H", 1576, 468, 283, 194, 120),
                new level(15, "77x77", "L", 4184, 125, 758, 520, 320),
                new level(15, "77x77", "M", 332, 991, 600, 412, 254),
                new level(15, "77x77", "Q", 236, 703, 426, 292, 180),
                new level(15, "77x77", "H", 1784, 530, 321, 220, 136),
                new level(16, "81x81", "L", 4712, 1408, 854, 586, 361),
                new level(16, "81x81", "M", 3624, 1082, 656, 450, 277),
                new level(16, "81x81", "Q", 26, 775, 470, 322, 198),
                new level(16, "81x81", "H", 2024, 602, 365, 250, 154),
                new level(17, "85x85", "L", 5176, 1548, 938, 644, 397),
                new level(17, "85x85", "M", 4056, 1212, 734, 504, 310),
                new level(17, "85x85", "Q", 2936, 876, 531, 364, 224),
                new level(17, "85x85", "H", 2264, 674, 408, 280, 173),
                new level(18, "89x89", "L", 5768, 1725, 1046, 718, 442),
                new level(18, "89x89", "M", 4504, 1346, 816, 560, 345),
                new level(18, "89x89", "Q", 3176, 948, 574, 394, 243),
                new level(18, "89x89", "H", 2504, 746, 452, 310, 191),
                new level(19, "93x93", "L", 636, 1903, 1153, 792, 488),
                new level(19, "93x93", "M", 5016, 15, 909, 624, 384),
                new level(19, "93x93", "Q", 356, 1063, 644, 442, 272),
                new level(19, "93x93", "H", 2728, 813, 493, 338, 208),
                new level(20, "97x97", "L", 6888, 2061, 1249, 858, 528),
                new level(20, "97x97", "M", 5352, 16, 970, 666, 410),
                new level(20, "97x97", "Q", 388, 1159, 702, 482, 297),
                new level(20, "97x97", "H", 308, 919, 557, 382, 235),
                new level(21, "101x101", "L", 7456, 2232, 1352, 929, 572),
                new level(21, "101x101", "M", 5712, 1708, 1035, 711, 438),
                new level(21, "101x101", "Q", 4096, 1224, 742, 509, 314),
                new level(21, "101x101", "H", 3248, 969, 587, 403, 248),
                new level(22, "105x105", "L", 8048, 2409, 146, 1003, 618),
                new level(22, "105x105", "M", 6256, 1872, 1134, 779, 480),
                new level(22, "105x105", "Q", 4544, 1358, 823, 565, 348),
                new level(22, "105x105", "H", 3536, 1056, 640, 439, 270),
                new level(23, "109x109", "L", 8752, 262, 1588, 1091, 672),
                new level(23, "109x109", "M", 688, 2059, 1248, 857, 528),
                new level(23, "109x109", "Q", 4912, 1468, 890, 611, 376),
                new level(23, "109x109", "H", 3712, 1108, 672, 461, 284),
                new level(24, "113x113", "L", 9392, 2812, 1704, 1171, 721),
                new level(24, "113x113", "M", 7312, 2188, 1326, 911, 561),
                new level(24, "113x113", "Q", 5312, 1588, 963, 661, 407),
                new level(24, "113x113", "H", 4112, 1228, 744, 511, 315),
                new level(25, "117x117", "L", 10208, 3057, 1853, 1273, 784),
                new level(25, "117x117", "M", 8, 2395, 1451, 997, 614),
                new level(25, "117x117", "Q", 5744, 1718, 1041, 715, 440),
                new level(25, "117x117", "H", 4304, 1286, 779, 535, 330),
                new level(26, "121x121", "L", 1096, 3283, 199, 1367, 842),
                new level(26, "121x121", "M", 8496, 2544, 1542, 1059, 652),
                new level(26, "121x121", "Q", 6032, 1804, 1094, 751, 462),
                new level(26, "121x121", "H", 4768, 1425, 864, 593, 365),
                new level(27, "125x125", "L", 11744, 3514, 2132, 1465, 902),
                new level(27, "125x125", "M", 9024, 2701, 1637, 1125, 692),
                new level(27, "125x125", "Q", 6464, 1933, 1172, 805, 496),
                new level(27, "125x125", "H", 5024, 1501, 910, 625, 385),
                new level(28, "129x129", "L", 12248, 3669, 2223, 1528, 940),
                new level(28, "129x129", "M", 9544, 2857, 1732, 119, 732),
                new level(28, "129x129", "Q", 6968, 2085, 1263, 868, 534),
                new level(28, "129x129", "H", 5288, 1581, 958, 658, 405),
                new level(29, "133x133", "L", 13048, 3909, 2369, 1628, 1002),
                new level(29, "133x133", "M", 10136, 3035, 1839, 1264, 778),
                new level(29, "133x133", "Q", 7288, 2181, 1322, 908, 559),
                new level(29, "133x133", "H", 5608, 1677, 1016, 698, 430),
                new level(30, "137x137", "L", 1388, 4158, 252, 1732, 1066),
                new level(30, "137x137", "M", 10984, 3289, 1994, 137, 843),
                new level(30, "137x137", "Q", 788, 2358, 1429, 982, 604),
                new level(30, "137x137", "H", 596, 1782, 108, 742, 457),
                new level(31, "141x141", "L", 14744, 4417, 2677, 184, 1132),
                new level(31, "141x141", "M", 1164, 3486, 2113, 1452, 894),
                new level(31, "141x141", "Q", 8264, 2473, 1499, 103, 634),
                new level(31, "141x141", "H", 6344, 1897, 115, 790, 486),
                new level(32, "145x145", "L", 1564, 4686, 284, 1952, 1201),
                new level(32, "145x145", "M", 12328, 3693, 2238, 1538, 947),
                new level(32, "145x145", "Q", 892, 267, 1618, 1112, 684),
                new level(32, "145x145", "H", 676, 2022, 1226, 842, 518),
                new level(33, "149x149", "L", 16568, 4965, 3009, 2068, 1273),
                new level(33, "149x149", "M", 13048, 3909, 2369, 1628, 1002),
                new level(33, "149x149", "Q", 9368, 2805, 17, 1168, 719),
                new level(33, "149x149", "H", 7208, 2157, 1307, 898, 553),
                new level(34, "153x153", "L", 17528, 5253, 3183, 2188, 1347),
                new level(34, "153x153", "M", 138, 4134, 2506, 1722, 106),
                new level(34, "153x153", "Q", 9848, 2949, 1787, 1228, 756),
                new level(34, "153x153", "H", 7688, 2301, 1394, 958, 590),
                new level(35, "157x157", "L", 18448, 5529, 3351, 2303, 1417),
                new level(35, "157x157", "M", 14496, 4343, 2632, 1809, 1113),
                new level(35, "157x157", "Q", 10288, 3081, 1867, 1283, 790),
                new level(35, "157x157", "H", 7888, 2361, 1431, 983, 605),
                new level(36, "161x161", "L", 19472, 5836, 3537, 2431, 1496),
                new level(36, "161x161", "M", 15312, 4588, 278, 1911, 1176),
                new level(36, "161x161", "Q", 10832, 3244, 1966, 1351, 832),
                new level(36, "161x161", "H", 8432, 2524, 153, 1051, 647),
                new level(37, "165x165", "L", 20528, 6153, 3729, 2563, 1577),
                new level(37, "165x165", "M", 15936, 4775, 2894, 1989, 1224),
                new level(37, "165x165", "Q", 11408, 3417, 2071, 1423, 876),
                new level(37, "165x165", "H", 8768, 2625, 1591, 1093, 673),
                new level(38, "169x169", "L", 21616, 6479, 3927, 2699, 1661),
                new level(38, "169x169", "M", 16816, 5039, 3054, 2099, 1292),
                new level(38, "169x169", "Q", 12016, 3599, 2181, 1499, 923),
                new level(38, "169x169", "H", 9136, 2735, 1658, 1139, 701),
                new level(39, "173x173", "L", 22496, 6743, 4087, 2809, 1729),
                new level(39, "173x173", "M", 17728, 5313, 322, 2213, 1362),
                new level(39, "173x173", "Q", 12656, 3791, 2298, 1579, 972),
                new level(39, "173x173", "H", 9776, 2927, 1774, 1219, 750),
                new level(40, "177x177", "L", 23648, 7089, 4296, 2953, 1817),
                new level(40, "177x177", "M", 18672, 5596, 3391, 2331, 1435),
                new level(40, "177x177", "Q", 13328, 3993, 242, 1663, 1024),
                new level(40, "177x177", "H", 10208, 3057, 1852, 1273, 784)
            };
        }
        public static bool doesFit(uint DataLength, uint iVersion, string sEncoding, string sECClevel){
            bool bRet=false;
            if(sEncoding != "Byte" && sEncoding != "AlphaNumeric" && sEncoding != "Numeric")
                return false; //unknown encoding

            foreach (level l in DataSizes.levels)
            {
                if (l.ECC_Level_String != sECClevel)
                    continue;
                if (l.version!=iVersion)
                    continue;
            //which capacity to look for
                if (sEncoding == "Byte")
                {
                    if (l.Capacity_Binary >= DataLength)
                    {
                        bRet = true;
                        break;
                    }
                }
                else if (sEncoding == "AlphaNumeric")
                {
                    if (l.Capacity_Alfanumeric >= DataLength)
                    {
                        bRet = true;
                        break;
                    }
                }
                else if (sEncoding == "Numeric")
                {
                    if (l.Capacity_Numeric >= DataLength)
                    {
                        bRet = true;
                        break;
                    }
                }
            }
            return bRet;
        }
    }
    // Version	Modules	ECC Level	Data bits	Numeric	Alfanumeric	Binary	Kanji
    public class level
    {
        public enum ECC_Levels
        {
            L,
            M,
            Q,
            H
        }
        public byte version;
        public string modulsize;
        private string _ECC_Level_String;
        public string ECC_Level_String
        {
            set
            {
                _ECC_Level_String = value;
                this._ecc_level = (ECC_Levels)Enum.Parse(typeof(ECC_Levels), value, true);
            }
            get
            {
                return _ECC_Level_String;
            }
        }
        private ECC_Levels _ecc_level;
        public ECC_Levels ecc_level
        {
            set
            {
                _ecc_level = value;
                this._ECC_Level_String = _ecc_level.ToString();
            }
            get
            {
                return _ecc_level;
            }
        }
        public uint rectSize{
            get{
                string[] fields=this.modulsize.Split(new char[]{'x'});
                return Convert.ToUInt16(fields[0]);
            }
            set{
                this.modulsize=value.ToString()+"x"+value.ToString();
            }
        }
        public uint Capacity_Bits;
        public uint Capacity_Numeric;
        public uint Capacity_Alfanumeric;
        public uint Capacity_Binary;
        public uint Capacity_Kanji;
        public level(byte _version, string _modulSize, string _ecc, uint _databits, uint _numeric, uint _alfanumeric, uint _binary, uint _kanji)
        {
            this.version = _version;
            this.modulsize = _modulSize;
            this.ECC_Level_String = _ecc;
            this.Capacity_Bits = _databits;
            this.Capacity_Numeric = _numeric;
            this.Capacity_Alfanumeric = _alfanumeric;
            this.Capacity_Binary = _binary;
            this.Capacity_Kanji = _kanji;
        }
    }
}
