using Cashback.Domain.Enums;
using Cashback.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Service.Util
{
    /// <summary>
    /// Fornece métodos para inserir valores default de cashback em um objeto do tipo List<CashbackByDayOfWeek>
    /// </summary>
    public static class GenerateData
    {
        #region Generate Rock
        public static List<CashbackByDayOfWeek> AddRock(this List<CashbackByDayOfWeek> list)
        {
            list.AddRange(new List<CashbackByDayOfWeek>() {
                new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Sunday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 40 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Monday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 10 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Tuesday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 15 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Wednesday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 15 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Thursday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 15 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Friday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 20 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Saturday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 40 }
            });
            return list;
        }
        #endregion

        #region Generate Pop
        public static List<CashbackByDayOfWeek> AddPop(this List<CashbackByDayOfWeek> list)
        {
            list.AddRange(new List<CashbackByDayOfWeek>() {
                new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Sunday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 25 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Monday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 7 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Tuesday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 6 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Wednesday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 2 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Thursday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 10 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Friday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 15 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Saturday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 20 }
            });
            return list;
        }
        #endregion

        #region Generate MPB
        public static List<CashbackByDayOfWeek> AddMpb(this List<CashbackByDayOfWeek> list)
        {
            list.AddRange(new List<CashbackByDayOfWeek>() {
                new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Sunday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 30 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Monday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 5 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Tuesday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 10 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Wednesday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 15 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Thursday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 20 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Friday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 25 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Saturday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 30 }
            });
            return list;
        }
        #endregion

        #region Generate Classic
        public static List<CashbackByDayOfWeek> AddClassic(this List<CashbackByDayOfWeek> list)
        {
            list.AddRange(new List<CashbackByDayOfWeek>() {
                new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Sunday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 35 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Monday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 3 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Tuesday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 5 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Wednesday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 8 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Thursday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 13 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Friday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 18 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Saturday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 25 }
            });
            return list;
        }
        #endregion

    }
}
