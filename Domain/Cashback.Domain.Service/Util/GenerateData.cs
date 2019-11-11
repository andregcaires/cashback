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
                new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Sunday.ToStringAndLower(), MusicStyle = AlbumStyles.rock.ToString(), Percentage = 40 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Monday.ToStringAndLower(), MusicStyle = AlbumStyles.rock.ToString(), Percentage = 10 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Tuesday.ToStringAndLower(), MusicStyle = AlbumStyles.rock.ToString(), Percentage = 15 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Wednesday.ToStringAndLower(), MusicStyle = AlbumStyles.rock.ToString(), Percentage = 15 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Thursday.ToStringAndLower(), MusicStyle = AlbumStyles.rock.ToString(), Percentage = 15 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Friday.ToStringAndLower(), MusicStyle = AlbumStyles.rock.ToString(), Percentage = 20 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Saturday.ToStringAndLower(), MusicStyle = AlbumStyles.rock.ToString(), Percentage = 40 }
            });
            return list;
        }
        #endregion

        #region Generate Pop
        public static List<CashbackByDayOfWeek> AddPop(this List<CashbackByDayOfWeek> list)
        {
            list.AddRange(new List<CashbackByDayOfWeek>() {
                new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Sunday.ToStringAndLower(), MusicStyle = AlbumStyles.pop.ToString(), Percentage = 25 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Monday.ToStringAndLower(), MusicStyle = AlbumStyles.pop.ToString(), Percentage = 7 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Tuesday.ToStringAndLower(), MusicStyle = AlbumStyles.pop.ToString(), Percentage = 6 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Wednesday.ToStringAndLower(), MusicStyle = AlbumStyles.pop.ToString(), Percentage = 2 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Thursday.ToStringAndLower(), MusicStyle = AlbumStyles.pop.ToString(), Percentage = 10 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Friday.ToStringAndLower(), MusicStyle = AlbumStyles.pop.ToString(), Percentage = 15 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Saturday.ToStringAndLower(), MusicStyle = AlbumStyles.pop.ToString(), Percentage = 20 }
            });
            return list;
        }
        #endregion

        #region Generate MPB
        public static List<CashbackByDayOfWeek> AddMpb(this List<CashbackByDayOfWeek> list)
        {
            list.AddRange(new List<CashbackByDayOfWeek>() {
                new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Sunday.ToStringAndLower(), MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 30 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Monday.ToStringAndLower(), MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 5 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Tuesday.ToStringAndLower(), MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 10 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Wednesday.ToStringAndLower(), MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 15 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Thursday.ToStringAndLower(), MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 20 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Friday.ToStringAndLower(), MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 25 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Saturday.ToStringAndLower(), MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 30 }
            });
            return list;
        }
        #endregion

        #region Generate Classic
        public static List<CashbackByDayOfWeek> AddClassic(this List<CashbackByDayOfWeek> list)
        {
            list.AddRange(new List<CashbackByDayOfWeek>() {
                new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Sunday.ToStringAndLower(), MusicStyle = AlbumStyles.classic.ToString(), Percentage = 35 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Monday.ToStringAndLower(), MusicStyle = AlbumStyles.classic.ToString(), Percentage = 3 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Tuesday.ToStringAndLower(), MusicStyle = AlbumStyles.classic.ToString(), Percentage = 5 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Wednesday.ToStringAndLower(), MusicStyle = AlbumStyles.classic.ToString(), Percentage = 8 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Thursday.ToStringAndLower(), MusicStyle = AlbumStyles.classic.ToString(), Percentage = 13 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Friday.ToStringAndLower(), MusicStyle = AlbumStyles.classic.ToString(), Percentage = 18 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Saturday.ToStringAndLower(), MusicStyle = AlbumStyles.classic.ToString(), Percentage = 25 }
            });
            return list;
        }
        #endregion

        private static string ToStringAndLower(this DayOfWeek dayOfWeek) =>  dayOfWeek.ToString().ToLower();

    }
}
