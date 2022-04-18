using Game.Model;
using Game.Model.ChEnInterfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAnimatedGif;

namespace Game.Renderer
{
    public class Display
    {
        /// <summary>
        /// Knight animation
        /// </summary>
        List<string> idleKnight = new List<string>

        {
            "pack://application:,,,/Game;component/Windows/AnimationKnight/idle/idle1.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/idle/idle2.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/idle/idle3.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/idle/idle4.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/idle/idle5.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/idle/idle6.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/idle/idle7.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/idle/idle8.png",

        };


        List<string> runKnight = new List<string>
        {
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run1.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run2.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run3.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run4.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run5.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run6.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run7.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run8.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run9.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run10.png",
        };

        List<string> attackKnight = new List<string>
        {
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack1.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack2.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack3.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack4.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack5.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack6.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack7.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack8.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack9.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack10.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack11.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack12.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack13.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack14.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack15.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack16.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack17.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack18.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack19.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack20.png",
        };

        List<string> deathKnight = new List<string>
        {
             "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death1.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death2.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death3.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death4.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death5.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death6.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death7.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death8.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death9.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death10.png",
        };

        /// <summary>
        /// Warlock animation
        /// </summary>
        List<string> idleWarlock = new List<string>

        {
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_00_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_01_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_02_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_03_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_04_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_05_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_06_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_07_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_08_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_09_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_10_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_11_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_12_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_13_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_14_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_15_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_16_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_17_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_18_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_19_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_20_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_21_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_22_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_23_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_24_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_25_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_26_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_27_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_28_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_29_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_30_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_31_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_32_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_33_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_34_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_35_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_36_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_37_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_38_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_39_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_40_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_41_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/idle/frame_42_delay-0.03s.png",

        };


        List<string> runWarlock = new List<string>
        {
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_00_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_01_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_02_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_03_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_04_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_05_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_06_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_07_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_08_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_09_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_10_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_11_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_12_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_13_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_14_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_15_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_16_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_17_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_18_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_19_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_20_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_21_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_22_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_23_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_24_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_25_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_26_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_27_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_28_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_29_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_30_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_31_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_32_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_33_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_34_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_35_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_36_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_37_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_38_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/run/frame_39_delay-0.03s.png",
        };

        List<string> attackWarlock = new List<string>
        {
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack1.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack2.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack3.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack4.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack5.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack6.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack7.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack8.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack9.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack10.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack11.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack12.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack13.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack14.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack15.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack16.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack17.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack18.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack19.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack20.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack21.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack22.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack23.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack24.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack25.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack26.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack27.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack28.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack29.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack30.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack31.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack32.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack33.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack34.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack35.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack36.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack37.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack38.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack39.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack40.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack41.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack42.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack43.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack44.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/attack/attack45.png",
        };

        List<string> deathWarlock = new List<string>
        {
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_00_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_01_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_02_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_03_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_04_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_05_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_06_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_07_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_09_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_10_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_11_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_12_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_13_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_14_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_15_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_16_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_17_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_18_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_19_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_20_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_21_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_22_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_23_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_24_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_25_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_26_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_27_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_28_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_29_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_30_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_31_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_32_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_33_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_34_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_35_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_36_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_37_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_38_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_39_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_40_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_41_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_42_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_43_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_44_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_45_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_46_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_47_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_48_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_49_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_50_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_51_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_52_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_53_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_54_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_55_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_56_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_57_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_58_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_59_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_60_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_61_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_62_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_63_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_64_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_65_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_66_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_67_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_68_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_69_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_70_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_71_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_72_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_73_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_74_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_75_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_76_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_77_delay-0.03s.png",
            "pack://application:,,,/Game;component/Windows/AnimationWarlock/death/frame_78_delay-0.03s.png",
        };


        /// <summary>
        /// Mage animation
        /// </summary>
        List<string> idleMage = new List<string>

        {
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-0.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-1.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-2.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-3.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-4.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-5.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-6.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-7.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-8.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-9.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-10.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-11.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-12.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-13.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-14.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-15.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-16.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-17.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-18.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-19.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-20.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-21.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-22.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-23.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-24.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-25.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-26.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-27.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-28.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-29.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-30.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-31.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-32.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-33.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-34.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-35.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-36.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-37.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-38.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-39.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-40.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-41.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-42.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-43.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-44.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-45.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-46.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-47.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-48.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-49.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-50.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-51.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-52.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-53.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-54.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-55.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-56.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-57.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-58.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-59.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-60.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-61.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-62.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-63.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-64.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-65.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-66.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-67.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-68.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-69.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-70.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-71.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-72.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-73.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-74.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-75.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-76.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/idle/output-onlinegiftools-77.png",

        };


        List<string> runMage = new List<string>
        {
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-0.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-1.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-2.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-3.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-4.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-5.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-6.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-7.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-8.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-9.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-10.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-11.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-12.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-13.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-14.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-15.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-16.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-17.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-18.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-19.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-20.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-21.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-22.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-23.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-24.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-25.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-26.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-27.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-28.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-29.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-30.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-31.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-32.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-33.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-34.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-35.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-36.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-37.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-38.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-39.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-40.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-41.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-42.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-43.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-44.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-45.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-46.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-47.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-48.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-49.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-50.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-51.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-52.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-53.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-54.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-55.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-56.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-57.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-58.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-59.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-60.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/run/output-onlinegiftools (2)-61.png",
        };

        List<string> attackMage = new List<string>
        {
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-0.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-1.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-2.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-3.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-4.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-5.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-6.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-7.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-8.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-9.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-10.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-11.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-12.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-13.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-14.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-15.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-16.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-17.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-18.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-19.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-20.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-21.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-22.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-23.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-24.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-25.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-26.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-27.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-28.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-29.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-30.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-31.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-32.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-33.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-34.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-35.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-36.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-37.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-38.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-39.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-40.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-41.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-42.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-43.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-44.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-45.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-46.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-47.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-48.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-49.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-50.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-51.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-52.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-53.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-54.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-55.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-56.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-57.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-58.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-59.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-60.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-61.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-62.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-63.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-64.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-65.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-66.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-67.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-68.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-69.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-70.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-71.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-72.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-73.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/attack/output-onlinegiftools (3)-74.png",

        };

        List<string> deathMage = new List<string>
        {
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-48.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-49.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-50.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-51.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-52.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-53.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-54.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-55.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-56.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-57.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-58.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-59.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-60.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-61.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-62.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-63.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-64.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-65.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-66.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-67.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-68.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-69.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-70.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-71.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-72.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-73.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-74.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-75.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-76.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-77.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-78.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-79.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-80.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-81.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-82.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-83.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-84.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-85.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-86.png",
            "pack://application:,,,/Game;component/Windows/AnimationMage/death/output-onlinegiftools (1)-87.png",

        };

        /// <summary>
        /// Boss animation
        /// </summary>

        /// <summary>
        /// Griffin animation
        /// </summary>


        /// <summary>
        /// PoisonMushroom animation
        /// </summary>


        /// <summary>
        /// SkeletonWarrior animation
        /// </summary>

        int playerCounter = 0;

        public void PlayPlayerAnimationIdle(Rectangle Player_Canvas, ICharacter playerobj)
        {
            Player_Canvas.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri(idleMage[playerCounter], UriKind.Absolute))
            };
            playerCounter++;
            if (playerCounter >= idleMage.Count - 1)
            {
                playerCounter = 0;
            }
        }
        public void PlayPlayerAnimationDeath(Rectangle Player_Canvas, ICharacter playerobj)
        {
            Player_Canvas.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri(deathMage[playerCounter], UriKind.Absolute))
            };
            playerCounter++;
            if (playerCounter >= deathMage.Count - 1)
            {
                playerCounter = 0;
            }
        }
        public void PlayPlayerAnimationRun(Rectangle Player_Canvas, ICharacter playerobj)
        {
            Player_Canvas.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri(runMage[playerCounter], UriKind.Absolute))
            };
            playerCounter++;
            if (playerCounter >= runMage.Count - 1)
            {
                playerCounter = 0;
            }
        }
        public void PlayPlayerAnimationAttack(Rectangle Player_Canvas, ICharacter playerobj)
        {
            Player_Canvas.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri(attackMage[playerCounter], UriKind.Absolute))
            };
            playerCounter++;
            if (playerCounter >= attackMage.Count - 1)
            {
                playerCounter = 0;
            }
        }
    }
}
