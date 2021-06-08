﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamControls.ViewModels;
using Steema.TeeChart;
using Steema.TeeChart.Drawing;
using static Steema.TeeChart.Axis;
using Steema.TeeChart.Styles;
using XamControls.Utils;

namespace XamControls.Styles
{
    public class Themes
    {

        private static ChartView BaseChart;
        private static Variables.Variables var = new Variables.Variables();
        private static FileController fileController = new FileController();
        public static int valorTheme;

        public Themes(ChartView chart)
        {

            BaseChart = new ChartView();
            BaseChart = chart;

        }

        // Según el tema seleccionado, entra en un método o en otro
        public static void AplicarTheme(ChartView BaseChart)
        {

            switch (valorTheme)
            {

                case 1:
                    BaseTheme(BaseChart);
                    break;
                default:
                    break;

            }

        }

        private static void BaseTheme(ChartView BaseChart)
        {

            // Propiedades principales del Chart

            BaseChart.HorizontalOptions = LayoutOptions.FillAndExpand;
            BaseChart.VerticalOptions = LayoutOptions.FillAndExpand;
            BaseChart.Margin = 0;

            // Aspect
            BaseChart.Chart.Aspect.View3D = false;

            // Panning
            BaseChart.Chart.Panning.Allow = ScrollModes.None;
            BaseChart.Chart.Panning.Active = false;

            // Zoom
            BaseChart.Chart.Zoom.Active = false;
            BaseChart.Chart.Zoom.Allow = false;
            BaseChart.Chart.Zoom.Zoomed = false;

            // Panel
            BaseChart.Chart.Panel.Gradient.Visible = false;
            BaseChart.Chart.Panel.Color = Color.White;
            BaseChart.Chart.Panel.Brush.Solid = true;
            BaseChart.Chart.Panel.Left = 0;
            BaseChart.Chart.Panel.Right = 0;
            BaseChart.Chart.Panel.MarginRight = 3;

            // Walls
            BaseChart.Chart.Walls.Left.Visible = false;
            BaseChart.Chart.Walls.Bottom.Visible = false;

            // Header
            BaseChart.Chart.Header.Visible = true;
            BaseChart.Chart.Header.Font.Size = 15;
            BaseChart.Chart.Header.Alignment = StringAlignment.Center;
            BaseChart.Chart.Header.TextAlign = StringAlignment.Center;
            BaseChart.Chart.Header.AdjustFrame = true;
            BaseChart.Chart.Header.Color = Color.Black;
            BaseChart.Chart.Header.Pen.Color = Color.Black;
            BaseChart.Chart.Header.TextFormat = TextFormat.Normal;
            BaseChart.Chart.Header.ShapeBounds = System.Drawing.Rectangle.Empty;
            BaseChart.Chart.Header.Font.Brush.Color = System.Drawing.Color.Black;

            // Title
            BaseChart.Chart.Header.Font.Bold = false;

            // SubHeader
            BaseChart.Chart.SubHeader.Visible = false;

            // Legend
            BaseChart.Chart.Legend.Visible = true;
            BaseChart.Chart.Legend.ResizeChart = true;
            BaseChart.Chart.Legend.Alignment = LegendAlignments.Bottom;
            BaseChart.Chart.Legend.TextAlign = StringAlignment.Near;
            BaseChart.Chart.Legend.Pen = new ChartPen { Visible = false };
            BaseChart.Chart.Legend.Shadow = new Shadow(BaseChart.Chart) { Visible = false };
            BaseChart.Chart.Legend.ColumnWidths[1] = 80;
            BaseChart.Chart.Legend.ColumnWidths[0] = 50;
            BaseChart.Chart.Legend.VertSpacing = 10;
            BaseChart.Chart.Legend.DrawBehind = false;
            BaseChart.Chart.Legend.TextSymbolGap = 6;
            BaseChart.Chart.Legend.Symbol = new LegendSymbol(BaseChart.Chart.Legend) { Squared = true, Width = 10 };
            BaseChart.Chart.Legend.LegendStyle = LegendStyles.Series;
            BaseChart.Chart.Legend.Font.Size = 13;
            BaseChart.Chart.Legend.MaxNumRows = 2;
            BaseChart.Chart.Legend.TextStyle = LegendTextStyles.Percent;
            BaseChart.Chart.Legend.Symbol.Position = LegendSymbolPosition.Left;

            // Axes
            BaseChart.Chart.Axes.Visible = true;
            BaseChart.Chart.Axes.Left.SetMinMax(BaseChart.Chart.Axes.Left.MinYValue, BaseChart.Chart.Axes.Left.MaxYValue);
            BaseChart.Chart.Axes.Bottom.SetMinMax(BaseChart.Chart.Axes.Bottom.MinXValue, BaseChart.Chart.Axes.Bottom.MaxXValue);

            BaseChart.Chart.Axes.Bottom.Labels.Font.Brush.Color = Color.FromRgb(128, 128, 128);
            BaseChart.Chart.Axes.Bottom.Labels.Font.Size = 12;

            BaseChart.Chart.Axes.Bottom.AxisPen.Visible = true;
            BaseChart.Chart.Axes.Bottom.AxisPen.Color = Color.FromRgb(200, 200, 200);
            BaseChart.Chart.Axes.Bottom.Grid.Visible = false;
            // TODO PEP BaseChart.Chart.Axes.Bottom.Ticks = new TicksPen { Width = 2, Visible = true, Color = Color.FromRgb(200, 200, 200), EndCap = PenLineCap.Flat, Style = DashStyle.Solid, Length = 10, };
            BaseChart.Chart.Axes.Bottom.Grid.Color = Color.FromRgb(210, 210, 210);
            BaseChart.Chart.Axes.Bottom.Inverted = false;
            BaseChart.Chart.Axes.Bottom.StartPosition = 0;
            BaseChart.Chart.Axes.Bottom.EndPosition = 100;
            BaseChart.Chart.Axes.Bottom.RelativePosition = 0;
            BaseChart.Chart.Axes.Bottom.Automatic = true;
            BaseChart.Chart.Axes.Bottom.Labels.OnAxis = true;
            BaseChart.Chart.Axes.Bottom.Title.Visible = false;

            BaseChart.Chart.Axes.Left.Labels.Font.Brush.Color = Color.FromRgb(128, 128, 128);
            BaseChart.Chart.Axes.Left.AxisPen.Color = Color.FromRgb(200, 200, 200);
            BaseChart.Chart.Axes.Left.Labels.Font.Size = 12;
            BaseChart.Chart.Axes.Left.AxisPen.Visible = false;
            // TODO PEP BaseChart.Chart.Axes.Left.Ticks = new TicksPen { Width = 2, Visible = true, Color = Color.FromRgb(200, 200, 200), EndCap = PenLineCap.Flat, Style = DashStyle.Solid, Length = 10, };
            BaseChart.Chart.Axes.Left.Grid.Color = Color.FromRgb(210, 210, 210);
            BaseChart.Chart.Axes.Left.StartPosition = 0;
            BaseChart.Chart.Axes.Left.EndPosition = 100;
            BaseChart.Chart.Axes.Left.Title.Visible = false;

            BaseChart.Chart.Axes.Right.Labels.Font.Brush.Color = Color.FromRgb(128, 128, 128);
            BaseChart.Chart.Axes.Right.AxisPen.Color = Color.FromRgb(200, 200, 200);
            BaseChart.Chart.Axes.Right.Labels.Font.Size = 12;
            BaseChart.Chart.Axes.Right.AxisPen.Visible = true;
            // TODO PEP BaseChart.Chart.Axes.Right.Ticks = new TicksPen { Width = 2, Visible = true, Color = Color.FromRgb(200, 200, 200), EndCap = PenLineCap.Flat, Style = DashStyle.Solid, Length = 10, };
            BaseChart.Chart.Axes.Right.Grid.Visible = false;
            BaseChart.Chart.Axes.Right.Grid.Color = Color.FromRgb(210, 210, 210);
            BaseChart.Chart.Axes.Right.Visible = false;

            BaseChart.Chart.Axes.Top.Labels.Font.Brush.Color = Color.FromRgb(128, 128, 128);
            BaseChart.Chart.Axes.Top.Labels.Font.Size = 12;
            BaseChart.Chart.Axes.Top.AxisPen.Visible = true;
            BaseChart.Chart.Axes.Top.AxisPen.Color = Color.FromRgb(200, 200, 200);
            BaseChart.Chart.Axes.Top.Grid.Visible = false;
            // TODO PEP BaseChart.Chart.Axes.Top.Ticks = new TicksPen { Width = 2, Visible = true, Color = Color.FromRgb(200, 200, 200), EndCap = PenLineCap.Flat, Style = DashStyle.Solid, Length = 10, };
            BaseChart.Chart.Axes.Top.Grid.Visible = false;
            BaseChart.Chart.Axes.Top.Grid.Color = Color.FromRgb(210, 210, 210);
            BaseChart.Chart.Axes.Top.Inverted = false;
            BaseChart.Chart.Axes.Top.Visible = false;

            // Footer
            BaseChart.Chart.Footer.Visible = false;

            // Rotation
            BaseChart.Rotation = 0;

            // MinorTicks Axis
            BaseChart.Chart.Axes.Left.MinorTicks.Visible = true;
            BaseChart.Chart.Axes.Left.MinorTicks.Width = 1;
            BaseChart.Chart.Axes.Left.MinorTicks.Length = 20;
            BaseChart.Chart.Axes.Left.MinorTicks.Transparency = 100;

            BaseChart.Rotation = 0;

            Themes.BasicAxes(BaseChart.Chart.Axes.Left, BaseChart.Chart.Axes.Right);

            if (Xamarin.Forms.Device.RuntimePlatform == Xamarin.Forms.Device.iOS)
            {
                for (int i = 0; i < BaseChart.Chart.Series.Count; i++) BaseChart.Chart.Series[i].Marks.AutoSize = true;
            }
        }

        public static void AplicarMarksTheme1(ChartView BaseChart)
        {
            Steema.TeeChart.Styles.Series series;
            for (int i = 0; i < BaseChart.Chart.Series.Count; i++)
            {
                series = BaseChart.Chart.Series[i];
                series.Marks.Font.Color = Color.White;
                series.Marks.Font.Size = 18;
                series.Marks.Shadow = new Shadow(series.Chart) { Visible = false };
                 series.Marks.Color = series[i].Color;
                series.Marks.ShapeStyle = TextShapeStyle.Rectangle;
                
                series.Marks.BorderRound = 0;
                series.Marks.TextAlign = StringAlignment.Center;
                series.Marks.InflateMargins = false;
                series.Marks.FollowSeriesColor = true;
                series.Marks.Bevel.Width = 0;
                series.Marks.AutoSize = false;
                series.Marks.Height = App.ScreenHeight / 13;
                series.Marks.Width = App.ScreenWidth / 5;
                series.Marks.ArrowLength = 35;
                series.Marks.Arrow.Color = Color.Transparent;
                series.Marks.Style = Steema.TeeChart.Styles.MarksStyles.Value;
                series.Marks.TailParams.PointerHeight = 10;
                series.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
                series.Marks.TailParams.PointerWidth = 12;
                series.Marks.Pen.Width = 1;
                // TODO PEP series.Marks.Pen.Color = series[i].Color.AddLuminosity(-0.3);

                if (Xamarin.Forms.Device.RuntimePlatform == Xamarin.Forms.Device.iOS)
                {
                    series.Marks.AutoSize = true;
                }
            }
        }

        public static void UpdateAxes(Axis left, Axis bot)
        {
            bot.Labels.Font.Brush.Color = Color.FromRgb(128, 128, 128);
            bot.Labels.Font.Size = 12;
            bot.AxisPen.Visible = true;
            bot.AxisPen.Color = Color.FromRgb(200, 200, 200);
            bot.Grid.Visible = false;
            // TODO PEP bot.Ticks = new TicksPen { Width = 2, Visible = true, Color = Color.FromRgb(200, 200, 200), EndCap = PenLineCap.Flat, Style = DashStyle.Solid, Length = 10, };
            bot.Grid.Color = Color.FromRgb(210, 210, 210);
            bot.Inverted = false;
            bot.StartPosition = 0;
            bot.EndPosition = 100;

            left.Labels.Font.Brush.Color = Color.FromRgb(128, 128, 128);
            left.AxisPen.Color = Color.FromRgb(200, 200, 200);
            left.Labels.Font.Size = 12;
            left.AxisPen.Visible = false;
            // TODO PEP left.Ticks = new TicksPen { Width = 2, Visible = true, Color = Color.FromRgb(200, 200, 200), EndCap = PenLineCap.Flat, Style = DashStyle.Solid, Length = 10, };
            left.Grid.Color = Color.FromRgb(210, 210, 210);
            left.StartPosition = 0;
            left.EndPosition = 100;

            left.MinorTicks.Visible = true;
            left.MinorTicks.Width = 1;
            left.MinorTicks.Length = 20;
            left.MinorTicks.Transparency = 100;
        }

        public static void BasicAxes(Axis left, Axis bot)
        {
            bot.AxisPen.Visible = true;
            bot.StartPosition = 0;
            bot.EndPosition = 100;

            left.AxisPen.Visible = false;
            left.StartPosition = 0;
            left.EndPosition = 100;
        }

        public static Axis CustomAxisLeft(Axis myAxisLeft)
        {
            myAxisLeft.StartPosition = 61;
            myAxisLeft.EndPosition = 100;
            myAxisLeft.RelativePosition = 0;
            myAxisLeft.Automatic = true;
            myAxisLeft.AxisPen.Color = BaseChart.Chart.Axes.Left.AxisPen.Color;
            myAxisLeft.Ticks = BaseChart.Chart.Axes.Left.Ticks;
            myAxisLeft.Ticks.Visible = true;
            myAxisLeft.Ticks.Transparency = 100;
            myAxisLeft.Ticks.Length = 15;
            myAxisLeft.MinorTicks.Transparency = 100;
            myAxisLeft.Grid.Visible = true;
            myAxisLeft.Grid.Color = BaseChart.Chart.Axes.Left.Grid.Color;
            myAxisLeft.Labels.Font = BaseChart.Chart.Axes.Left.Labels.Font;
            myAxisLeft.Labels.Transparency = 0;
            myAxisLeft.Labels.Visible = true;
            myAxisLeft.Increment = 20;
            myAxisLeft.AxisPen.Visible = false;

            return myAxisLeft;
        }

        public static Axis CustomAxisRight(Axis myAxisRight)
        {
            myAxisRight.StartPosition = 61;
            myAxisRight.EndPosition = 100;
            myAxisRight.RelativePosition = 0;
            myAxisRight.Automatic = true;
            myAxisRight.AxisPen.Color = BaseChart.Chart.Axes.Left.AxisPen.Color;
            myAxisRight.Ticks = BaseChart.Chart.Axes.Left.Ticks;
            myAxisRight.Ticks.Visible = true;
            myAxisRight.Ticks.Transparency = 100;
            myAxisRight.Ticks.Length = 15;
            myAxisRight.MinorTicks.Transparency = 100;
            myAxisRight.Grid.Visible = true;
            myAxisRight.Grid.Color = BaseChart.Chart.Axes.Left.Grid.Color;
            myAxisRight.Labels.Font = BaseChart.Chart.Axes.Left.Labels.Font;
            myAxisRight.Labels.Transparency = 0;
            myAxisRight.Labels.Visible = true;
            myAxisRight.Increment = 20;
            myAxisRight.AxisPen.Visible = false;
            myAxisRight.OtherSide = true;

            return myAxisRight;
        }

        public static void DoubleAxisChart(ChartView BaseChart)
        {
            BaseChart.Chart.Axes.Left.RelativePosition = 0;
            BaseChart.Chart.Axes.Left.StartPosition = 0;
            BaseChart.Chart.Axes.Left.EndPosition = 55;
            //BaseChart.Chart.Axes.Left.Automatic = true;
            BaseChart.Chart.Axes.Left.Ticks.Transparency = 100;

            BaseChart.Chart.Axes.Bottom.RelativePosition = 0;
            BaseChart.Chart.Axes.Bottom.StartPosition = 0;
            BaseChart.Chart.Axes.Bottom.EndPosition = 100;
            //BaseChart.Chart.Axes.Bottom.Automatic = true;
        }

        public static void TripleAxisChart(ChartView BaseChart, Axis leftCenterAxis, Axis leftBottomAxis)
        {
            BaseChart.Chart.Axes.Left.RelativePosition = 0;
            BaseChart.Chart.Axes.Left.StartPosition = 0;
            BaseChart.Chart.Axes.Left.EndPosition = 30;
            BaseChart.Chart.Axes.Left.Ticks.Transparency = 100;

            leftCenterAxis.RelativePosition = 0;
            leftCenterAxis.StartPosition = 35;
            leftCenterAxis.EndPosition = 65;
            leftCenterAxis.Ticks.Transparency = 100;

            leftBottomAxis.RelativePosition = 0;
            leftBottomAxis.StartPosition = 70;
            leftBottomAxis.EndPosition = 100;
            leftBottomAxis.Ticks.Transparency = 100;
        }
#if !TEE_STD
        public static void CandleGodStyle(Candle candle)
        {
            candle.CandleWidth = 9;
            candle.UpCloseColor = var.GetPaletteBasic[0];
            candle.DownCloseColor = var.GetPaletteBasic[1];
        }
#endif

        public static void RefreshTheme()
        {
            AplicarTheme(BaseChart);
        }

        // Aplica el themes de TeeChart per defecte
        public static void AplicarOptions(ChartView chart)
        {
            string themeActual = fileController.LeerThemeActual();
            bool zoomEnabled = fileController.LeerZoomActual();
            bool panningEnabled = fileController.BooleanReadValues("panning:");
            //string zoomTypeActual = fileController.LeerZoomTypeActual();
            switch (themeActual)
            {

                case "None":
                    chart.Chart.SetTheme(ThemeType.None);
                    break;
                case "BlackIsBack":
                    chart.Chart.SetTheme(ThemeType.BlackIsBack);
                    break;
                case "Opera":
                    chart.Chart.SetTheme(ThemeType.Opera);
                    break;
                case "TeeChart":
                    chart.Chart.SetTheme(ThemeType.TeeChart);
                    break;
                case "Excel":
                    chart.Chart.SetTheme(ThemeType.Excel);
                    break;
                case "Classic":
                    chart.Chart.SetTheme(ThemeType.Classic);
                    break;
                case "XP":
                    chart.Chart.SetTheme(ThemeType.XP);
                    break;
                case "Web":
                    chart.Chart.SetTheme(ThemeType.Web);
                    break;
                case "Business":
                    chart.Chart.SetTheme(ThemeType.Business);
                    break;
                case "BlueSky":
                    chart.Chart.SetTheme(ThemeType.BlueSky);
                    break;
                case "Grayscale":
                    chart.Chart.SetTheme(ThemeType.Grayscale);
                    break;
                case "Lookout":
                    chart.Chart.SetTheme(ThemeType.Lookout);
                    break;
                case "Andros":
                    chart.Chart.SetTheme(ThemeType.Andros);
                    break;
                case "Report":
                    chart.Chart.SetTheme(ThemeType.Report);
                    break;
            }

            if (chart.Chart.Header.Text != "Zoom and Panning a Chart")
            {
                chart.Chart.Zoom.Active = zoomEnabled;
                chart.Chart.Zoom.Allow = zoomEnabled;

                chart.Chart.Panning.Active = panningEnabled;
                if (panningEnabled) { chart.Chart.Panning.Allow = ScrollModes.Both; }
                else { chart.Chart.Panning.Allow = ScrollModes.None; }
            }
        }
    }
}
