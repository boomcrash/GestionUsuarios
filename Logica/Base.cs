using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionUsuarios.Logica
{
    public class Base
    {
        public static void DiseñoDtv(ref DataGridView Listado)
        {
            Listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Listado.BackgroundColor = Color.FromArgb(26, 33, 37);
            Listado.ForeColor = Color.FromArgb(26, 33, 37);
            Listado.EnableHeadersVisualStyles = false;
            Listado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Listado.BorderStyle = BorderStyle.None;
            Listado.CellBorderStyle = DataGridViewCellBorderStyle.None;

            Listado.RowHeadersVisible = false;

            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();
            cabecera.BackColor = Color.FromArgb(26, 33, 37);
            cabecera.ForeColor = Color.White;
            cabecera.SelectionBackColor = Color.SeaGreen;
            cabecera.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Listado.ColumnHeadersDefaultCellStyle = cabecera;
        }



        public static object Decimales(TextBox cajita, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') || e.KeyChar == ',')
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && (~cajita.Text.IndexOf(".")) != 0)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            return null;

        }

        public enum DateInterval{
            Day,
            DayOfYear,
            Hour,
            Minute,
            Month,
            Quarter,
            Second,
            Weekday,
            WeekOfYear,
            Year
        }


        public static long DateDiff(DateInterval intervalType,DateTime dateOne,DateTime datetwo)
        {
            switch (intervalType)
            {
                case DateInterval.Day:

                case DateInterval.DayOfYear:
                    TimeSpan spanForDays = datetwo - dateOne;
                    return (long)spanForDays.TotalDays;
                case DateInterval.Hour:
                    TimeSpan spanForHours = datetwo - dateOne;
                    return (long)spanForHours.TotalHours;
                case DateInterval.Minute:
                    TimeSpan spanForMinutes = datetwo - dateOne;
                    return (long)spanForMinutes.TotalMinutes;
                case DateInterval.Month:
                    return ((datetwo.Year-dateOne.Year)*12)+(datetwo.Month-dateOne.Month);
                case DateInterval.Quarter:
                    long dateOneQuarter = (long)Math.Ceiling(dateOne.Month / 3.0);
                    long dateTwoQuarter = (long)Math.Ceiling(datetwo.Month / 3.0);
                    return (4*(datetwo.Year-dateOne.Year)) +dateTwoQuarter-dateOneQuarter;
                case DateInterval.Second:
                    TimeSpan spanForSeconds = datetwo - dateOne;
                    return (long)spanForSeconds.TotalSeconds;
                case DateInterval.Weekday:
                    TimeSpan spanForWeekdays = datetwo - dateOne;
                    return (long)(spanForWeekdays.TotalDays/7.0);
                case DateInterval.WeekOfYear:
                    DateTime DateOneModified = dateOne;
                    DateTime DateTwoModified = datetwo;
                    while (DateTwoModified.DayOfWeek != DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
                    {
                        DateTwoModified = DateTwoModified.AddDays(-1);
                    }
                    while (DateOneModified.DayOfWeek != DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
                    {
                        DateOneModified = DateOneModified.AddDays(-1);
                    }
                    TimeSpan SpanForWeekOfYear = DateTwoModified - DateOneModified;
                    return (long)(SpanForWeekOfYear.TotalDays / 7.0);
                case DateInterval.Year:
                    return datetwo.Year-dateOne.Year;
                default:
                    return 0;
            }

        }
    }
}
