using GRBLSettingsAndCofiguration.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRBLSettingsAndCofiguration
{
    internal static class GRBLSettingsConfigs
    {

        public static string[][] GetSettings(string SettingsName)
        {
            switch (SettingsName)
            {
                case "grbl11settings":
                    return grbl11settings;
                    break;
                default:
                    throw new Exception("Invalid settings name");
                    break;
            }
        }
        
        public static Dictionary<int, string> GetErrorCodes(string GRBLVersion)
        {
            switch (GRBLVersion)
            {
                case "1.1":
                    return GRBL11ErrorCodes;
                    break;
                default:
                    throw new Exception("Version not available");
                    break;
            }
        }

        public static string GetErrorForCode(int code, string Version)
        {
            switch (Version)
            {
                case "1.1":
                    if (GRBL11ErrorCodes.Keys.Contains(code))
                    {
                        return GRBL11ErrorCodes[code];
                    }
                    else
                    {
                        throw new Exception("Invalid error code");
                    }
                    break;
                default:
                    throw new Exception("Version error codes not found");
            }
        }

        public static Dictionary<string,string> GRBLVersions = new Dictionary<string, string>() 
        {   
            ["1.1"] = "grbl11settings"
        };

        public static Dictionary<int, string> GRBL11ErrorCodes = new Dictionary<int, string>()
        {
            [1] = "GCode Command letter was not found.",
            [2] = "GCode Command value invalid or missing.",
            [3] = "Grbl '$' not recognized or supported.",
            [4] = "Negative value for an expected positive value.",
            [5] = "Homing fail. Homing not enabled in settings.",
            [6] = "Min step pulse must be greater than 3usec.",
            [7] = "EEPROM read failed. Default values used.",
            [8] = "Grbl '$' command Only valid when Idle.",
            [9] = "GCode commands invalid in alarm or jog state.",
            [10] = "Soft limits require homing to be enabled.",
            [11] = "Max characters per line exceeded. Ignored.",
            [12] = "Grbl '$' setting exceeds the maximum step rate.",
            [13] = "Safety door opened and door state initiated.",
            [14] = "Build info or start-up line > EEPROM line length",
            [15] = "Jog target exceeds machine travel, ignored.",
            [16] = "Jog Cmd missing '=' or has prohibited GCode.",
            [17] = "Laser mode requires PWM output.",
            [20] = "Unsupported or invalid GCode command.",
            [21] = "> 1 GCode command in a modal group in block.",
            [22] = "Feed rate has not yet been set or is undefined.",
            [23] = "GCode command requires an integer value.",
            [24] = "> 1 GCode command using axis words found.",
            [25] = "Repeated GCode word found in block.",
            [26] = "No axis words found in command block.",
            [27] = "Line number value is invalid.",
            [28] = "GCode Cmd missing a required value word.",
            [29] = "G59.x WCS are not supported.",
            [30] = "G53 only valid with G0 and G1 motion modes.",
            [31] = "Unneeded Axis words found in block.",
            [32] = "G2/G3 arcs need >= 1 in-plane axis word.",
            [33] = "Motion command target is invalid.",
            [34] = "Arc radius value is invalid.",
            [35] = "G2/G3 arcs need >= 1 in-plane offset word.",
            [36] = "Unused value words found in block.",
            [37] = "G43.1 offset not assigned to tool length axis.",
            [38] = "Tool number greater than max value."
        };


        // code, name, type
        public static string[][] grbl11settings = new string[][]
        {
            new string[] { "$0","Step pulse (microseconds)", "number"},
            new string[] { "$1","Step idle delay (milliseconds)", "number"},
            new string[] { "$2","Step port invert, (XYZmask)", "axismask" },
            new string[] { "$3", "Direction port invert, (XYZmask), The direction each axis moves.", "axismask"},
            new string[] { "$4","Step enable invert", "YesNo"},
            new string[] { "$5","Limit pins invert", "YesNo"},
            new string[] { "$6","Probe pin invert", "YesNo"},
            new string[] { "$10","Status report", "mask"},
            new string[] { "$11","Junction deviation (mm)", "number"},
            new string[] { "$12","Arc tolerance (mm)", "number"},
            new string[] { "$13","Report in inches", "YesNo"},
            new string[] { "$20","Soft limits", "EnableDisable"},
            new string[] { "$21","Hard limits", "EnableDisable"},
            new string[] { "$22","Homing cycle", "EnableDisable"},
            new string[] { "$23","Homing direction invert (XYZmask)", "axismask"},
            new string[] { "$24","Homing feed(mm/min)", "number"},
            new string[] { "$25","Homing seek (mm/min)", "number"},
            new string[] { "$26","Homing debounce (milliseconds)", "number"},
            new string[] { "$27","Homing pull-off (mm)", "number"},
            new string[] { "$30","Max spindle speed (RPM)", "number"},
            new string[] { "$31","Min spindle speed, (RPM)", "number"},
            new string[] { "$32","Laser mode", "OnOff"},
            new string[] { "$100","X Steps/mm (Number of X steps to move 1mm)", "number"},
            new string[] { "$101","Y Steps/mm (Number of Y steps to move 1mm)", "number"},
            new string[] { "$102","Z Steps/mm (Number of Z steps to move 1mm)", "number"},
            new string[] { "$110","X Max rate (mm/min)", "number" },
            new string[] { "$111","Y Max rate (mm/min)", "number" },
            new string[] { "$112","Z Max rate (mm/min)", "number" },
            new string[] { "$120","X Acceleration (mm/sec^2)", "number" },
            new string[] { "$121","Y Acceleration (mm/sec^2)", "number" },
            new string[] { "$122","Z Acceleration (mm/sec^2)", "number" },
            new string[] { "$130","X Max travel (mm - Only for Homing and Soft Limits.)", "number" },
            new string[] { "$131","Y Max travel (mm - Only for Homing and Soft Limits.)", "number" },
            new string[] { "$132","Z Max travel (mm - Only for Homing and Soft Limits.)", "number" }
        };


        public static DataTable AxisMasks
        {
            get
            {
                DataTable dtAxisMasks = new DataTable();
                dtAxisMasks.Columns.Add("Mask");
                dtAxisMasks.Columns.Add("Description");
                dtAxisMasks.Rows.Add("0", "None");
                dtAxisMasks.Rows.Add("1", "X Only");
                dtAxisMasks.Rows.Add("10", "Y Only");
                dtAxisMasks.Rows.Add("11", "X and Y");
                dtAxisMasks.Rows.Add("100", "Z Only");
                dtAxisMasks.Rows.Add("101", "X and Z");
                dtAxisMasks.Rows.Add("110", "Y and Z");
                dtAxisMasks.Rows.Add("111", "X, Y and Z");

                return dtAxisMasks;

            }
        }



    }
}
