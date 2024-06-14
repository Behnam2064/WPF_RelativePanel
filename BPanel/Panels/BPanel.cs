using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Collections;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Threading;

namespace WPF_RP.Panels
{
    public enum RelativeProperty
    {
        None,
        AboveOf,
        AboveXCenterOf,
        AboveRightOf,
        AboveRightOutsideOf,
        AboveLeftOutsideOf,
        BelowOf,
        BelowXCenterOf,
        BelowRightOf,
        BelowRightOutsideOf,
        BelowLeftOutsideOf,
        FrontOf,
        FrontYCenterOf,
        FrontBottomOf,
        BehindOf,
        BehindYCenterOf,
        BehindBottomOf,
        #region Just one direction is related
        LeftStartOfWith, // Just left X
        RightStartOfWith, // Just right X
        AboveStartOfWith, // Just top Y
        BottomStartOfWith, // Just botton Y
        #endregion
        CenterOfPanel,
        CenterVerticalOfPanel,
        CenterHorizontalOfPanel,

        XStartWithCenterOfPanel, // Just left X (Center vertical panel)
        YStartWithCenterOfPanel, // Just left Y  (Center Horizental panel)

        AboveLeftOfPanel,
        AboveRightOfPanel,
        BottomLeftOfPanel,
        BottomRightOfPanel,
        InsideCenterIn,
        InsideAboveLeftIn,
        InsideBottomLeftIn,
        InsideAboveRightIn,
        InsideBottomRightIn,
        ClipInside,


        InsideCenterAboveIn,
        InsideCenterBottomIn,

        InsideCenterLeftIn,
        InsideCenterRightIn


    }

    /// <summary>
    /// Very important point to use the current class.
    /// Elements that affect the location of other classes should be written at the beginning of xaml
    /// </summary>
    public class BPanel : Panel
    {

        public BPanel() 
        {
        }

        #region Below of

        public static UIElement GetBelowOf(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(BelowOfProperty);
        }

        public static void SetBelowOf(DependencyObject obj, UIElement value)
        {
            obj.SetValue(BelowOfProperty, value);
        }

        // Using a DependencyProperty as the backing store for BelowOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BelowOfProperty =
            DependencyProperty.RegisterAttached("BelowOf", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region BelowRightOf

        public static UIElement GetBelowRightOf(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(BelowRightOfProperty);
        }

        public static void SetBelowRightOf(DependencyObject obj, UIElement value)
        {
            obj.SetValue(BelowRightOfProperty, value);
        }

        // Using a DependencyProperty as the backing store for BelowRightOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BelowRightOfProperty =
            DependencyProperty.RegisterAttached("BelowRightOf", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region BelowRightOutsideOf

        public static UIElement GetBelowRightOutsideOf(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(BelowRightOutsideOfProperty);
        }

        public static void SetBelowRightOutsideOf(DependencyObject obj, UIElement value)
        {
            obj.SetValue(BelowRightOutsideOfProperty, value);
        }

        // Using a DependencyProperty as the backing store for BelowRightOutsideOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BelowRightOutsideOfProperty =
            DependencyProperty.RegisterAttached("BelowRightOutsideOf", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region BelowLeftOutsideOf

        public static UIElement GetBelowLeftOutsideOf(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(BelowLeftOutsideOfProperty);
        }

        public static void SetBelowLeftOutsideOf(DependencyObject obj, UIElement value)
        {
            obj.SetValue(BelowLeftOutsideOfProperty, value);
        }

        // Using a DependencyProperty as the backing store for BelowLeftOutsideOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BelowLeftOutsideOfProperty =
            DependencyProperty.RegisterAttached("BelowLeftOutsideOf", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region BelowXCenterOf

        public static UIElement GetBelowXCenterOf(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(BelowXCenterOfProperty);
        }

        public static void SetBelowXCenterOf(DependencyObject obj, UIElement value)
        {
            obj.SetValue(BelowXCenterOfProperty, value);
        }

        // Using a DependencyProperty as the backing store for BelowXCenterOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BelowXCenterOfProperty =
            DependencyProperty.RegisterAttached("BelowXCenterOf", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region Top on


        public static UIElement GetInsideAboveLeftIn(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(InsideAboveLeftInProperty);
        }

        public static void SetInsideAboveLeftIn(DependencyObject obj, UIElement value)
        {
            obj.SetValue(InsideAboveLeftInProperty, value);
        }

        // Using a DependencyProperty as the backing store for InsideAboveLeftIn.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InsideAboveLeftInProperty =
            DependencyProperty.RegisterAttached("InsideAboveLeftIn", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region inside center on


        public static UIElement GetInsideCenterIn(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(InsideCenterInProperty);
        }

        public static void SetInsideCenterIn(DependencyObject obj, UIElement value)
        {
            obj.SetValue(InsideCenterInProperty, value);
        }

        // Using a DependencyProperty as the backing store for InsideCenterIn.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InsideCenterInProperty =
            DependencyProperty.RegisterAttached("InsideCenterIn", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region inside center on


        public static UIElement GetInsideBottomLeftIn(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(InsideBottomLeftInProperty);
        }

        public static void SetInsideBottomLeftIn(DependencyObject obj, UIElement value)
        {
            obj.SetValue(InsideBottomLeftInProperty, value);
        }

        // Using a DependencyProperty as the backing store for InsideBottomLeftIn.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InsideBottomLeftInProperty =
            DependencyProperty.RegisterAttached("InsideBottomLeftIn", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion        

        #region inside center on


        public static UIElement GetInsideAboveRightIn(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(InsideAboveRightInProperty);
        }

        public static void SetInsideAboveRightIn(DependencyObject obj, UIElement value)
        {
            obj.SetValue(InsideAboveRightInProperty, value);
        }

        // Using a DependencyProperty as the backing store for InsideAboveRightIn.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InsideAboveRightInProperty =
            DependencyProperty.RegisterAttached("InsideAboveRightIn", typeof(UIElement), typeof(BPanel),
         new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region inside center on


        public static UIElement GetInsideBottomRightIn(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(InsideBottomRightInProperty);
        }

        public static void SetInsideBottomRightIn(DependencyObject obj, UIElement value)
        {
            obj.SetValue(InsideBottomRightInProperty, value);
        }

        // Using a DependencyProperty as the backing store for InsideBottomRightIn.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InsideBottomRightInProperty =
            DependencyProperty.RegisterAttached("InsideBottomRightIn", typeof(UIElement), typeof(BPanel),
                    new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region inside center on


        public static UIElement GetInsideCenterAboveIn(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(InsideCenterAboveInProperty);
        }

        public static void SetInsideCenterAboveIn(DependencyObject obj, UIElement value)
        {
            obj.SetValue(InsideCenterAboveInProperty, value);
        }

        // Using a DependencyProperty as the backing store for InsideCenterAboveIn.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InsideCenterAboveInProperty =
            DependencyProperty.RegisterAttached("InsideCenterAboveIn", typeof(UIElement), typeof(BPanel),
             new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region inside center on


        public static UIElement GetInsideCenterBottomIn(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(InsideCenterBottomInProperty);
        }

        public static void SetInsideCenterBottomIn(DependencyObject obj, UIElement value)
        {
            obj.SetValue(InsideCenterBottomInProperty, value);
        }

        // Using a DependencyProperty as the backing store for InsideCenterBottomIn.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InsideCenterBottomInProperty =
            DependencyProperty.RegisterAttached("InsideCenterBottomIn", typeof(UIElement), typeof(BPanel),
            new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region inside center on


        public static UIElement GetInsideCenterLeftIn(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(InsideCenterLeftInProperty);
        }

        public static void SetInsideCenterLeftIn(DependencyObject obj, UIElement value)
        {
            obj.SetValue(InsideCenterLeftInProperty, value);
        }

        // Using a DependencyProperty as the backing store for InsideCenterLeftIn.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InsideCenterLeftInProperty =
            DependencyProperty.RegisterAttached("InsideCenterLeftIn", typeof(UIElement), typeof(BPanel),
           new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region inside center on


        public static UIElement GetInsideCenterRightIn(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(InsideCenterRightInProperty);
        }

        public static void SetInsideCenterRightIn(DependencyObject obj, UIElement value)
        {
            obj.SetValue(InsideCenterRightInProperty, value);
        }

        // Using a DependencyProperty as the backing store for InsideCenterRightIn.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InsideCenterRightInProperty =
            DependencyProperty.RegisterAttached("InsideCenterRightIn", typeof(UIElement), typeof(BPanel),
           new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region ClipInside


        public static UIElement GetClipInside(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(ClipInsideProperty);
        }

        public static void SetClipInside(DependencyObject obj, UIElement value)
        {
            obj.SetValue(ClipInsideProperty, value);
        }

        // Using a DependencyProperty as the backing store for ClipInside.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClipInsideProperty =
            DependencyProperty.RegisterAttached("ClipInside", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region FontOf

        public static UIElement GetFrontOf(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(FrontOfProperty);
        }

        public static void SetFrontOf(DependencyObject obj, UIElement value)
        {
            obj.SetValue(FrontOfProperty, value);
        }

        // Using a DependencyProperty as the backing store for FrontOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FrontOfProperty =
            DependencyProperty.RegisterAttached("FrontOf", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });



        #endregion


        #region FrontYCenterOf

        public static UIElement GetFrontYCenterOf(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(FrontYCenterOfProperty);
        }

        public static void SetFrontYCenterOf(DependencyObject obj, UIElement value)
        {
            obj.SetValue(FrontYCenterOfProperty, value);
        }

        // Using a DependencyProperty as the backing store for FrontYCenterOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FrontYCenterOfProperty =
            DependencyProperty.RegisterAttached("FrontYCenterOf", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });


        #endregion

        #region FrontBottomOf

        public static UIElement GetFrontBottomOf(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(FrontBottomOfProperty);
        }

        public static void SetFrontBottomOf(DependencyObject obj, UIElement value)
        {
            obj.SetValue(FrontBottomOfProperty, value);
        }

        // Using a DependencyProperty as the backing store for FrontBottomOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FrontBottomOfProperty =
            DependencyProperty.RegisterAttached("FrontBottomOf", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });



        #endregion

        #region Above of


        public static UIElement GetAboveOf(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(AboveOfProperty);
        }

        public static void SetAboveOf(DependencyObject obj, UIElement value)
        {
            obj.SetValue(AboveOfProperty, value);
        }

        // Using a DependencyProperty as the backing store for AboveOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AboveOfProperty =
            DependencyProperty.RegisterAttached("AboveOf", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region AboveRightOf


        public static UIElement GetAboveRightOf(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(AboveRightOfProperty);
        }

        public static void SetAboveRightOf(DependencyObject obj, UIElement value)
        {
            obj.SetValue(AboveRightOfProperty, value);
        }

        // Using a DependencyProperty as the backing store for AboveRightOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AboveRightOfProperty =
            DependencyProperty.RegisterAttached("AboveRightOf", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region AboveRightOutsideOf


        public static UIElement GetAboveRightOutsideOf(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(AboveRightOutsideOfProperty);
        }

        public static void SetAboveRightOutsideOf(DependencyObject obj, UIElement value)
        {
            obj.SetValue(AboveRightOutsideOfProperty, value);
        }

        // Using a DependencyProperty as the backing store for AboveRightOutsideOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AboveRightOutsideOfProperty =
            DependencyProperty.RegisterAttached("AboveRightOutsideOf", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region AboveLeftOutsideOf


        public static UIElement GetAboveLeftOutsideOf(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(AboveLeftOutsideOfProperty);
        }

        public static void SetAboveLeftOutsideOf(DependencyObject obj, UIElement value)
        {
            obj.SetValue(AboveLeftOutsideOfProperty, value);
        }

        // Using a DependencyProperty as the backing store for AboveLeftOutsideOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AboveLeftOutsideOfProperty =
            DependencyProperty.RegisterAttached("AboveLeftOutsideOf", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region Above X Center Of


        public static UIElement GetAboveXCenterOf(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(AboveXCenterOfProperty);
        }

        public static void SetAboveXCenterOf(DependencyObject obj, UIElement value)
        {
            obj.SetValue(AboveXCenterOfProperty, value);
        }

        // Using a DependencyProperty as the backing store for AboveXCenterOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AboveXCenterOfProperty =
            DependencyProperty.RegisterAttached("AboveXCenterOf", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region Behind of

        public static UIElement GetBehindOf(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(BehindOfProperty);
        }

        public static void SetBehindOf(DependencyObject obj, UIElement value)
        {
            obj.SetValue(BehindOfProperty, value);
        }

        // Using a DependencyProperty as the backing store for BehindOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BehindOfProperty =
            DependencyProperty.RegisterAttached("BehindOf", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });


        #endregion

        #region BehindYCenterOf

        public static UIElement GetBehindYCenterOf(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(BehindYCenterOfProperty);
        }

        public static void SetBehindYCenterOf(DependencyObject obj, UIElement value)
        {
            obj.SetValue(BehindYCenterOfProperty, value);
        }

        // Using a DependencyProperty as the backing store for BehindYCenterOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BehindYCenterOfProperty =
            DependencyProperty.RegisterAttached("BehindYCenterOf", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });


        #endregion

        #region BehindBottomOf

        public static UIElement GetBehindBottomOf(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(BehindBottomOfProperty);
        }

        public static void SetBehindBottomOf(DependencyObject obj, UIElement value)
        {
            obj.SetValue(BehindBottomOfProperty, value);

        }

        // Using a DependencyProperty as the backing store for BehindBottomOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BehindBottomOfProperty =
            DependencyProperty.RegisterAttached("BehindBottomOf", typeof(UIElement), typeof(BPanel),
                 new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });


        #endregion

        #region Left Start Of Wtih

        public static UIElement GetLeftStartOfWith(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(LeftStartOfWithProperty);
        }

        public static void SetLeftStartOfWith(DependencyObject obj, UIElement value)
        {
            obj.SetValue(LeftStartOfWithProperty, value);
        }

        // Using a DependencyProperty as the backing store for LeftOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LeftStartOfWithProperty =
            DependencyProperty.RegisterAttached("LeftStartOfWith", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region Right Start Of Wtih

        public static UIElement GetRightStartOfWith(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(RightStartOfWithProperty);
        }

        public static void SetRightStartOfWith(DependencyObject obj, UIElement value)
        {
            obj.SetValue(RightStartOfWithProperty, value);
        }

        // Using a DependencyProperty as the backing store for LeftOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RightStartOfWithProperty =
            DependencyProperty.RegisterAttached("RightStartOfWith", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region Top Start Of Wtih

        public static UIElement GetAboveStartOfWith(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(AboveStartOfWithProperty);
        }

        public static void SetAboveStartOfWith(DependencyObject obj, UIElement value)
        {
            obj.SetValue(AboveStartOfWithProperty, value);
        }

        // Using a DependencyProperty as the backing store for LeftOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AboveStartOfWithProperty =
            DependencyProperty.RegisterAttached("AboveStartOfWith", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region Button Start Of Wtih

        public static UIElement GetBottomStartOfWith(DependencyObject obj)
        {
            return (UIElement)obj.GetValue(BottomStartOfWithProperty);
        }

        public static void SetBottomStartOfWith(DependencyObject obj, UIElement value)
        {
            obj.SetValue(BottomStartOfWithProperty, value);
        }

        // Using a DependencyProperty as the backing store for LeftOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BottomStartOfWithProperty =
            DependencyProperty.RegisterAttached("BottomStartOfWith", typeof(UIElement), typeof(BPanel),
                new FrameworkPropertyMetadata() { DefaultValue = null, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region Center of panel


        public static bool GetCenterOfPanel(DependencyObject obj)
        {
            return (bool)obj.GetValue(CenterOfPanelProperty);
        }

        public static void SetCenterOfPanel(DependencyObject obj, bool value)
        {
            obj.SetValue(CenterOfPanelProperty, value);
        }

        // Using a DependencyProperty as the backing store for ClipInside.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CenterOfPanelProperty =
            DependencyProperty.RegisterAttached("CenterOfPanel", typeof(bool), typeof(BPanel), new FrameworkPropertyMetadata() { DefaultValue = false, AffectsMeasure = true, AffectsParentMeasure = true });

        #endregion

        #region Center vertical of panel

        public static bool GetCenterVerticalOfPanel(DependencyObject obj)
        {
            return (bool)obj.GetValue(CenterVerticalOfPanelProperty);
        }

        public static void SetCenterVerticalOfPanel(DependencyObject obj, bool value)
        {
            obj.SetValue(CenterVerticalOfPanelProperty, value);
        }

        // Using a DependencyProperty as the backing store for CenterVerticalOfPanel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CenterVerticalOfPanelProperty =
            DependencyProperty.RegisterAttached("CenterVerticalOfPanel", typeof(bool), typeof(BPanel), new FrameworkPropertyMetadata() { DefaultValue = false, AffectsMeasure = true, AffectsParentMeasure = true });


        #endregion

        #region X start with center of panel

        public static bool GetXStartWithCenterOfPanel(DependencyObject obj)
        {
            return (bool)obj.GetValue(XStartWithCenterOfPanelProperty);
        }

        public static void SetXStartWithCenterOfPanel(DependencyObject obj, bool value)
        {
            obj.SetValue(XStartWithCenterOfPanelProperty, value);
        }

        // Using a DependencyProperty as the backing store for XStartWithCenterOfPanel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XStartWithCenterOfPanelProperty =
            DependencyProperty.RegisterAttached("XStartWithCenterOfPanel", typeof(bool), typeof(BPanel), new FrameworkPropertyMetadata() { DefaultValue = false, AffectsMeasure = true, AffectsParentMeasure = true });


        #endregion


        #region Y start with center of panel

        public static bool GetYStartWithCenterOfPanel(DependencyObject obj)
        {
            return (bool)obj.GetValue(YStartWithCenterOfPanelProperty);
        }

        public static void SetYStartWithCenterOfPanel(DependencyObject obj, bool value)
        {
            obj.SetValue(YStartWithCenterOfPanelProperty, value);
        }

        // Using a DependencyProperty as the backing store for YStartWithCenterOfPanel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty YStartWithCenterOfPanelProperty =
            DependencyProperty.RegisterAttached("YStartWithCenterOfPanel", typeof(bool), typeof(BPanel), new FrameworkPropertyMetadata() { DefaultValue = false, AffectsMeasure = true, AffectsParentMeasure = true });


        #endregion

        #region Center Horizontal Of Panel


        public static bool GetCenterHorizontalOfPanel(DependencyObject obj)
        {
            return (bool)obj.GetValue(CenterHorizontalOfPanelProperty);
        }

        public static void SetCenterHorizontalOfPanel(DependencyObject obj, bool value)
        {
            obj.SetValue(CenterHorizontalOfPanelProperty, value);
        }

        // Using a DependencyProperty as the backing store for CenterHorizontalOfPanel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CenterHorizontalOfPanelProperty =
            DependencyProperty.RegisterAttached("CenterHorizontalOfPanel", typeof(bool), typeof(BPanel), new FrameworkPropertyMetadata() { DefaultValue = false, AffectsMeasure = true, AffectsParentMeasure = true });


        #endregion

        #region Top Left Of Panel


        public static bool GetAboveLeftOfPanel(DependencyObject obj)
        {
            return (bool)obj.GetValue(AboveLeftOfPanelProperty);
        }

        public static void SetAboveLeftOfPanel(DependencyObject obj, bool value)
        {
            obj.SetValue(AboveLeftOfPanelProperty, value);
        }

        // Using a DependencyProperty as the backing store for AboveLeftOfPanel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AboveLeftOfPanelProperty =
            DependencyProperty.RegisterAttached("AboveLeftOfPanel", typeof(bool), typeof(BPanel), new FrameworkPropertyMetadata() { DefaultValue = false, AffectsMeasure = true, AffectsParentMeasure = true });


        #endregion

        #region Top Right Of Panel


        public static bool GetAboveRightOfPanel(DependencyObject obj)
        {
            return (bool)obj.GetValue(AboveRightOfPanelProperty);
        }

        public static void SetAboveRightOfPanel(DependencyObject obj, bool value)
        {
            obj.SetValue(AboveRightOfPanelProperty, value);
        }

        // Using a DependencyProperty as the backing store for AboveRightOfPanel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AboveRightOfPanelProperty =
            DependencyProperty.RegisterAttached("AboveRightOfPanel", typeof(bool), typeof(BPanel), new FrameworkPropertyMetadata() { DefaultValue = false, AffectsMeasure = true, AffectsParentMeasure = true });


        #endregion

        #region Bottom Left Of Panel


        public static bool GetBottomLeftOfPanel(DependencyObject obj)
        {
            return (bool)obj.GetValue(BottomLeftOfPanelProperty);
        }

        public static void SetBottomLeftOfPanel(DependencyObject obj, bool value)
        {
            obj.SetValue(BottomLeftOfPanelProperty, value);
        }

        // Using a DependencyProperty as the backing store for BottomLeftOfPanel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BottomLeftOfPanelProperty =
            DependencyProperty.RegisterAttached("BottomLeftOfPanel", typeof(bool), typeof(BPanel), new FrameworkPropertyMetadata() { DefaultValue = false, AffectsMeasure = true, AffectsParentMeasure = true });


        #endregion

        #region Bottom Right Of Panel


        public static bool GetBottomRightOfPanel(DependencyObject obj)
        {
            return (bool)obj.GetValue(BottomRightOfPanelProperty);
        }

        public static void SetBottomRightOfPanel(DependencyObject obj, bool value)
        {
            obj.SetValue(BottomRightOfPanelProperty, value);
        }

        // Using a DependencyProperty as the backing store for BottomRightOfPanel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BottomRightOfPanelProperty =
            DependencyProperty.RegisterAttached("BottomRightOfPanel", typeof(bool), typeof(BPanel), new FrameworkPropertyMetadata() { DefaultValue = false, AffectsMeasure = true, AffectsParentMeasure = true });


        #endregion



        protected override Size MeasureOverride(Size availableSize)
        {
            //Size CurrentColumnSize = new Size();

            foreach (UIElement item in InternalChildren)
            {
                item.Measure(availableSize);
            }

            return availableSize;
            #region Old way

            /*Size PanelSize = new Size();

            foreach (UIElement child in InternalChildren)
            {


                #region Clip inside other element

                UIElement ParentAttatched = GetClipInside(child);
                if (ParentAttatched != null)
                {

                    List<RelativeProperty> LPropertyAttached = new List<RelativeProperty>();



                    #region Arrange Below of

                    UIElement ParentAttached = GetBelowOf(child);
                    if (ParentAttached != null)
                    {
                        LPropertyAttached.Add(RelativeProperty.BelowOf);

                        var ChildSize = new Rect(GetPointBelowOf(ParentAttached, this), child.DesiredSize);
                        ApplySizeElement(ref availableSize, ChildSize, child);

                        continue;
                            

                    }
                    #endregion












                    child.Measure(ParentAttatched.DesiredSize);
                    continue;
                }

                #endregion
                child.Measure(availableSize);
                *//*
                                PanelSize.Height += child.DesiredSize.Height;
                                PanelSize.Width += child.DesiredSize.Width;*//*

            }


            return availableSize; 
*/

            #endregion
        }

        protected void ApplySizeElement(ref Size AvailablePanelSize, Rect childSize, UIElement child)
        {
            if (childSize.Width > AvailablePanelSize.Width)
                AvailablePanelSize.Width += childSize.Width - AvailablePanelSize.Width;

            if (childSize.Height > AvailablePanelSize.Height)
                AvailablePanelSize.Height += childSize.Height - AvailablePanelSize.Height;

            child.Measure(AvailablePanelSize);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {

            foreach (UIElement child in InternalChildren)
            {


                List<RelativeProperty> LPropertyAttached = new List<RelativeProperty>();

                #region Arrange Below of

                UIElement ParentAttached = GetBelowOf(child);
                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.BelowOf);

                    ApplyArrange(child, GetPointBelowOf(ParentAttached, this));
                    //child.Arrange(new Rect(GetPointBelowOf(ParentAttached, this), child.DesiredSize));


                }
                #endregion

                #region Arrange Below of


                ParentAttached = GetBelowRightOf(child);
                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.BelowRightOf);

                    ApplyArrange(child, GetPointBelowRightOf(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointBelowRightOf(child, ParentAttached, this), child.DesiredSize));

                }
                #endregion

                #region Arrange BelowRightOutsideOf


                ParentAttached = GetBelowRightOutsideOf(child);
                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.BelowRightOutsideOf);

                    ApplyArrange(child, GetPointBelowRightOutsideOf(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointBelowRightOutsideOf(child, ParentAttached, this), child.DesiredSize));

                }
                #endregion

                #region Arrange BelowLeftOutsideOf


                ParentAttached = GetBelowLeftOutsideOf(child);
                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.BelowLeftOutsideOf);

                    ApplyArrange(child, GetPointBelowLeftOutsideOf(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointBelowLeftOutsideOf(child, ParentAttached, this), child.DesiredSize));

                }
                #endregion

                #region Arrange BelowXCenterOf


                ParentAttached = GetBelowXCenterOf(child);
                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.BelowXCenterOf);

                    ApplyArrange(child, GetPointBelowXCenterOf(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointBelowXCenterOf(child, ParentAttached, this), child.DesiredSize));

                }
                #endregion

                #region Arrange Front of

                ParentAttached = null;
                ParentAttached = GetFrontOf(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.FrontOf);

                    ApplyArrange(child, GetPointFrontOf(ParentAttached, this));
                    //child.Arrange(new Rect(GetPointFrontOf(ParentAttached, this), child.DesiredSize));
                }

                #endregion

                #region Arrange Front Y Center Of

                ParentAttached = null;
                ParentAttached = GetFrontYCenterOf(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.FrontYCenterOf);

                    ApplyArrange(child, GetPointFrontYCenterOf(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointFrontYCenterOf(child, ParentAttached, this), child.DesiredSize));
                }

                #endregion

                #region Arrange Front of

                ParentAttached = null;
                ParentAttached = GetFrontBottomOf(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.FrontBottomOf);

                    ApplyArrange(child, GetPointFrontBottomOf(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointFrontBottomOf(child, ParentAttached, this), child.DesiredSize));
                }

                #endregion

                #region Arrange Above of

                ParentAttached = null;
                ParentAttached = GetAboveOf(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.AboveOf);

                    ApplyArrange(child, GetPointAboveOf(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointAboveOf(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Arrange AboveRightOf

                ParentAttached = null;
                ParentAttached = GetAboveRightOf(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.AboveRightOf);

                    ApplyArrange(child, GetPointAboveRightOf(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointAboveRightOf(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Arrange AboveRightOutsideOf

                ParentAttached = null;
                ParentAttached = GetAboveRightOutsideOf(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.AboveRightOutsideOf);

                    ApplyArrange(child, GetPointAboveRightOutsideOf(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointAboveRightOutsideOf(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Arrange AboveLeftOutsideOf

                ParentAttached = null;
                ParentAttached = GetAboveLeftOutsideOf(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.AboveLeftOutsideOf);

                    ApplyArrange(child, GetPointAboveLeftOutsideOf(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointAboveLeftOutsideOf(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Arrange AboveXCenterOf

                ParentAttached = null;
                ParentAttached = GetAboveXCenterOf(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.AboveXCenterOf);

                    ApplyArrange(child, GetPointAboveXCenterOf(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointAboveXCenterOf(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Arrange inside above left in

                ParentAttached = null;
                ParentAttached = GetInsideAboveLeftIn(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.InsideAboveLeftIn);
                    ApplyArrange(child, GetPointInsideAboveLeftIn(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointInsideAboveLeftIn(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Arrange inside center in

                ParentAttached = null;
                ParentAttached = GetInsideCenterAboveIn(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.InsideCenterAboveIn);

                    ApplyArrange(child, GetPointInsideCenterAboveIn(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointInsideCenterAboveIn(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Arrange inside center in

                ParentAttached = null;
                ParentAttached = GetInsideCenterBottomIn(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.InsideCenterBottomIn);

                    ApplyArrange(child, GetPointInsideCenterBottomIn(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointInsideCenterBottomIn(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Arrange inside center in

                ParentAttached = null;
                ParentAttached = GetInsideCenterLeftIn(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.InsideCenterLeftIn);

                    ApplyArrange(child, GetPointInsideCenterLeftIn(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointInsideCenterLeftIn(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion        

                #region Arrange inside center in

                ParentAttached = null;
                ParentAttached = GetInsideCenterRightIn(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.InsideCenterRightIn);

                    ApplyArrange(child, GetPointInsideCenterRightIn(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointInsideCenterRightIn(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Arrange inside center in

                ParentAttached = null;
                ParentAttached = GetInsideCenterIn(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.InsideCenterIn);

                    ApplyArrange(child, GetPointInsideCenterIn(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointInsideCenterIn(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Arrange inside bottom left in

                ParentAttached = null;
                ParentAttached = GetInsideBottomLeftIn(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.InsideBottomLeftIn);

                    ApplyArrange(child, GetPointInsideBottomLeftIn(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointInsideBottomLeftIn(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Arrange Inside above right in

                ParentAttached = null;
                ParentAttached = GetInsideAboveRightIn(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.InsideAboveRightIn);

                    ApplyArrange(child, GetPointInsideAboveRightIn(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointInsideAboveRightIn(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Arrange Inside bottom right in

                ParentAttached = null;
                ParentAttached = GetInsideBottomRightIn(child);

                if (ParentAttached != null)
                {

                    LPropertyAttached.Add(RelativeProperty.InsideBottomRightIn);

                    ApplyArrange(child, GetPointInsideBottomRightIn(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointInsideBottomRightIn(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Arrange left start of wtih

                ParentAttached = null;
                ParentAttached = GetLeftStartOfWith(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.LeftStartOfWith);

                    ApplyArrange(child, GetPointLeftStartOfWtih(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointLeftStartOfWtih(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Arrange right start of wtih

                ParentAttached = null;
                ParentAttached = GetRightStartOfWith(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.RightStartOfWith);

                    ApplyArrange(child, GetPointRightStartOfWtih(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointRightStartOfWtih(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Arrange button start of wtih

                ParentAttached = null;
                ParentAttached = GetBottomStartOfWith(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.BottomStartOfWith);

                    ApplyArrange(child, GetPointBottomStartOfWtih(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointBottomStartOfWtih(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Arrange above start of wtih

                ParentAttached = null;
                ParentAttached = GetAboveStartOfWith(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.AboveStartOfWith);
                    ApplyArrange(child, GetPointAboveStartOfWtih(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointAboveStartOfWtih(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Center of panel

                bool GoCenter = GetCenterOfPanel(child);

                if (GoCenter)
                {
                    LPropertyAttached.Add(RelativeProperty.CenterOfPanel);

                    // Center Horizental
                    Point h = GetPointCenterHorizontalOfPanel(finalSize, child);

                    // Center Vertical
                    Point v = GetPointCenterVerticalOfPanel(finalSize, child);


                    ApplyArrange(child, new Point(h.X, v.Y));
                    //child.Arrange(new Rect(new Point(h.X, v.Y), child.DesiredSize));
                }

                #endregion

                #region Center vertical of panel

                bool GoCenterVerticalOfPanel = GetCenterVerticalOfPanel(child);

                if (GoCenterVerticalOfPanel)
                {
                    LPropertyAttached.Add(RelativeProperty.CenterVerticalOfPanel);

                    ApplyArrange(child, GetPointCenterVerticalOfPanel(finalSize, child));
                    //child.Arrange(new Rect(GetPointCenterVerticalOfPanel(finalSize, child), child.DesiredSize));
                }



                #endregion

                #region X start with center of panel

                bool GXStartWithCenterOfPanel = GetXStartWithCenterOfPanel(child);

                if (GXStartWithCenterOfPanel)
                {
                    LPropertyAttached.Add(RelativeProperty.XStartWithCenterOfPanel);

                    // Center Vertical
                    /* double helfPanelHeight = finalSize.Height / 2;
                     double helfChildHeight = child.DesiredSize.Height / 2;
                     double StartPointHeight = helfPanelHeight - helfChildHeight;

                     var x = child.TranslatePoint(new Point(0, 0), this).X; // self*/

                    ApplyArrange(child, GetPointXStartWithCenterOfPanel(finalSize, child, this));
                    //child.Arrange(new Rect(GetPointXStartWithCenterOfPanel(finalSize, child, this), child.DesiredSize));
                }



                #endregion  

                #region Y start with center of panel

                bool GYStartWithCenterOfPanel = GetYStartWithCenterOfPanel(child);

                if (GYStartWithCenterOfPanel)
                {
                    LPropertyAttached.Add(RelativeProperty.YStartWithCenterOfPanel);
                    // Center Horizental
                    ApplyArrange(child, GetPointYStartWithCenterOfPanel(finalSize, child, this));
                    //child.Arrange(new Rect(GetPointYStartWithCenterOfPanel(finalSize, child, this), child.DesiredSize));
                }



                #endregion

                #region Center Horizontal of panel

                bool GoCenterHorizontal = GetCenterHorizontalOfPanel(child);

                if (GoCenterHorizontal)
                {
                    LPropertyAttached.Add(RelativeProperty.CenterHorizontalOfPanel);

                    ApplyArrange(child, GetPointCenterHorizontalOfPanel(finalSize, child));
                    //child.Arrange(new Rect(GetPointCenterHorizontalOfPanel(finalSize, child), child.DesiredSize));
                }



                #endregion

                #region Above left of panel

                bool GoAboveLeftOfPanel = GetAboveLeftOfPanel(child);

                if (GoAboveLeftOfPanel)
                {
                    LPropertyAttached.Add(RelativeProperty.AboveLeftOfPanel);
                    Point point = GetPointAboveLeftOfPanel();
                    ApplyArrange(child, point);
                    //child.Arrange(new Rect(point, child.DesiredSize));

                }



                #endregion

                #region Above right of panel

                bool GoAboveRightOfPanel = GetAboveRightOfPanel(child);

                if (GoAboveRightOfPanel)
                {
                    LPropertyAttached.Add(RelativeProperty.AboveRightOfPanel);

                    ApplyArrange(child, GetPointAboveRightOfPanel(finalSize, child));
                    //child.Arrange(new Rect(GetPointAboveRightOfPanel(finalSize, child), child.DesiredSize));
                }



                #endregion

                #region Bottom right of panel

                bool GoBottomRightOfPanel = GetBottomRightOfPanel(child);

                if (GoBottomRightOfPanel)
                {
                    LPropertyAttached.Add(RelativeProperty.BottomRightOfPanel);
                    ApplyArrange(child, GetPointBottomRightOfPanel(finalSize, child));
                    //child.Arrange(new Rect(GetPointBottomRightOfPanel(finalSize, child), child.DesiredSize));
                }
                #endregion

                #region Bottom Left Of Panel

                bool GoBottomLeftOfPanel = GetBottomLeftOfPanel(child);

                if (GoBottomLeftOfPanel)
                {
                    LPropertyAttached.Add(RelativeProperty.BottomLeftOfPanel);

                    ApplyArrange(child, GetPointBottomLeftOfPanel(finalSize, child));
                    //child.Arrange(new Rect(GetPointBottomLeftOfPanel(finalSize, child), child.DesiredSize));
                }
                #endregion

                #region Arrange Behind of

                ParentAttached = null;
                ParentAttached = GetBehindOf(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.BehindOf);

                    ApplyArrange(child, GetPointBehindOf(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointBehindOf(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region Arrange Behind of

                ParentAttached = null;
                ParentAttached = GetBehindYCenterOf(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.BehindYCenterOf);

                    ApplyArrange(child, GetPointBehindYCenterOf(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointBehindYCenterOf(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region BehindBottomOf

                ParentAttached = null;
                ParentAttached = GetBehindBottomOf(child);

                if (ParentAttached != null)
                {
                    LPropertyAttached.Add(RelativeProperty.BehindBottomOf);


                    ApplyArrange(child, GetPointBehindBottomOf(child, ParentAttached, this));
                    //child.Arrange(new Rect(GetPointBehindBottomOf(child, ParentAttached, this), child.DesiredSize));
                }
                #endregion

                #region None property
                // همیشه باید آخر باشد چون که مقدار لیست زیر در انتها کامل میشود
                if (LPropertyAttached.Count < 1)
                {
                    ApplyArrange(child, new Point(0, 0));
                    //child.Arrange(new Rect(new Point(0, 0), child.DesiredSize));
                }

                #endregion


            }


            return finalSize; // Returns the final Arranged size
        }


        public void ApplyArrange(UIElement uI, Point location)
        {
            Size size = uI.DesiredSize;
            object ob = uI.GetValue(FrameworkElement.MarginProperty);
            if (ob != null)
            {
                Thickness t = (Thickness)ob;
                
                location.X += t.Left + t.Right;
                location.Y += t.Top + t.Bottom;
            }
            uI.Arrange(new Rect(location, size));

        }



        private Point GetPointInsideCenterRightIn(UIElement child, UIElement UIInsideCenterAboveInThis, UIElement relativeTo)
        {
            Point point = GetPointInsideCenterIn(child, UIInsideCenterAboveInThis, relativeTo);

            double X = point.X + UIInsideCenterAboveInThis.DesiredSize.Width / 2 - child.DesiredSize.Width / 2;

            return new Point(X, point.Y);
        }

        private Point GetPointInsideCenterLeftIn(UIElement child, UIElement UIInsideCenterAboveInThis, UIElement relativeTo)
        {
            Point point = GetPointInsideCenterIn(child, UIInsideCenterAboveInThis, relativeTo);

            double X = point.X - UIInsideCenterAboveInThis.DesiredSize.Width / 2 + child.DesiredSize.Width / 2;

            return new Point(X, point.Y);
        }

        private Point GetPointInsideCenterBottomIn(UIElement child, UIElement UIInsideCenterAboveInThis, UIElement relativeTo)
        {
            Point point = GetPointInsideCenterIn(child, UIInsideCenterAboveInThis, relativeTo);

            double Y = point.Y + UIInsideCenterAboveInThis.DesiredSize.Height / 2 - child.DesiredSize.Height / 2;
            //double centerY = ParentPoint.Y + UIAboveStartOfWtihThis.DesiredSize.Height - child.DesiredSize.Height;
            return new Point(point.X, Y);
        }

        private Point GetPointInsideCenterAboveIn(UIElement child, UIElement UIInsideCenterAboveInThis, UIElement relativeTo)
        {
            Point point = GetPointInsideCenterIn(child, UIInsideCenterAboveInThis, relativeTo);

            double Y = point.Y - UIInsideCenterAboveInThis.DesiredSize.Height / 2 + child.DesiredSize.Height / 2;


            return new Point(point.X, Y);
        }

        private Point GetPointBelowOf(UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);

            double top = UIAboveStartOfWtihThis.DesiredSize.Height + ParentPoint.Y;
            return new Point(ParentPoint.X, top);
        }

        private Point GetPointBelowRightOf(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);

            double top = UIAboveStartOfWtihThis.DesiredSize.Height + ParentPoint.Y;
            Point CenterX = GetPointInsideCenterRightIn(child, UIAboveStartOfWtihThis, RelatedTo);
            return new Point(CenterX.X, top);
        }

        private Point GetPointBelowRightOutsideOf(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);

            double top = UIAboveStartOfWtihThis.DesiredSize.Height + ParentPoint.Y;
            Point CenterX = GetPointFrontOf(UIAboveStartOfWtihThis, RelatedTo);
            return new Point(CenterX.X, top);
        }

        private Point GetPointBelowLeftOutsideOf(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);

            double top = UIAboveStartOfWtihThis.DesiredSize.Height + ParentPoint.Y;
            Point CenterX = GetPointBehindOf(child, UIAboveStartOfWtihThis, RelatedTo);
            return new Point(CenterX.X, top);
        }

        private Point GetPointBelowXCenterOf(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);

            double top = UIAboveStartOfWtihThis.DesiredSize.Height + ParentPoint.Y;
            Point pointX = GetPointInsideCenterIn(child, UIAboveStartOfWtihThis, RelatedTo);
            return new Point(pointX.X, top);
        }


        private Point GetPointFrontYCenterOf(UIElement child, UIElement UIAboveStartOfWtihThis, BPanel RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);
            var Front = UIAboveStartOfWtihThis.DesiredSize.Width + ParentPoint.X;
            Point centerY = GetPointInsideCenterIn(child, UIAboveStartOfWtihThis, RelatedTo);
            return new Point(Front, centerY.Y);
        }

        private Point GetPointFrontBottomOf(UIElement child, UIElement UIAboveStartOfWtihThis, BPanel RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);
            var Front = UIAboveStartOfWtihThis.DesiredSize.Width + ParentPoint.X;
            //double centerY = ParentPoint.Y + UIAboveStartOfWtihThis.DesiredSize.Height - child.DesiredSize.Height;
            Point centerY = GetPointInsideCenterBottomIn(child, UIAboveStartOfWtihThis, RelatedTo);
            return new Point(Front, centerY.Y);
        }

        private Point GetPointFrontOf(UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);
            var Front = UIAboveStartOfWtihThis.DesiredSize.Width + ParentPoint.X;
            return new Point(Front, ParentPoint.Y);
        }


        private Point GetPointAboveOf(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);
            return new Point(ParentPoint.X, ParentPoint.Y - child.DesiredSize.Height);
        }


        private Point GetPointAboveRightOf(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);
            Point CenterX = GetPointInsideCenterRightIn(child, UIAboveStartOfWtihThis, RelatedTo);
            return new Point(CenterX.X, ParentPoint.Y - child.DesiredSize.Height);
        }


        private Point GetPointAboveRightOutsideOf(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);
            Point CenterX = GetPointFrontOf(UIAboveStartOfWtihThis, RelatedTo);
            return new Point(CenterX.X, ParentPoint.Y - child.DesiredSize.Height);
        }


        private Point GetPointAboveLeftOutsideOf(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);
            Point CenterX = GetPointBehindOf(child, UIAboveStartOfWtihThis, RelatedTo);
            return new Point(CenterX.X, ParentPoint.Y - child.DesiredSize.Height);
        }


        private Point GetPointAboveXCenterOf(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);
            Point centerX = GetPointInsideCenterIn(child, UIAboveStartOfWtihThis, RelatedTo);
            return new Point(centerX.X, ParentPoint.Y - child.DesiredSize.Height);
        }




        private Point GetPointInsideAboveLeftIn(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);
            return new Point(ParentPoint.X, ParentPoint.Y);
        }

        private Point GetPointInsideCenterIn(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);


            double X = ParentPoint.X;
            double Y = ParentPoint.Y;

            X += UIAboveStartOfWtihThis.DesiredSize.Width / 2;
            Y += UIAboveStartOfWtihThis.DesiredSize.Height / 2;

            X -= child.DesiredSize.Width / 2;
            Y -= child.DesiredSize.Height / 2;
            return new Point(X, Y);
        }

        private Point GetPointInsideBottomLeftIn(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);

            double X = ParentPoint.X;
            double Y = ParentPoint.Y + UIAboveStartOfWtihThis.DesiredSize.Height - child.DesiredSize.Height;

            return new Point(X, Y);
        }

        private Point GetPointInsideAboveRightIn(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);

            double X = ParentPoint.X + UIAboveStartOfWtihThis.DesiredSize.Width - child.DesiredSize.Width;
            double Y = ParentPoint.Y;

            return new Point(X, Y);
        }

        private Point GetPointInsideBottomRightIn(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point ParentPoint = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);

            double X = ParentPoint.X + UIAboveStartOfWtihThis.DesiredSize.Width - child.DesiredSize.Width;
            double Y = ParentPoint.Y + UIAboveStartOfWtihThis.DesiredSize.Height - child.DesiredSize.Height;

            return new Point(X, Y);
        }

        private Point GetPointLeftStartOfWtih(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point PointParent = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);
            double Left = PointParent.X - child.DesiredSize.Width;
            double Top = GetPointSelfUIElement(child, RelatedTo).Y;
            return new Point(Left, Top);
        }

        private Point GetPointRightStartOfWtih(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point PointParent = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);
            double Right = PointParent.X + UIAboveStartOfWtihThis.DesiredSize.Width;
            // در اینجا فقط مقدار ایکس رو تغییر میدهیم و مقدار وای را به حال خود می گذاریم
            Point Top = GetPointSelfUIElement(child, RelatedTo); //  self 
            return new Point(Right, Top.Y);
        }
        private Point GetPointBottomStartOfWtih(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point PointParent = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo);
            Point Left = GetPointSelfUIElement(child, RelatedTo);
            return new Point(Left.X, PointParent.Y + UIAboveStartOfWtihThis.DesiredSize.Height);
        }

        private Point GetPointYStartWithCenterOfPanel(Size FinalSizePanel, UIElement child, UIElement RelativeTo)
        {
            Point CenterY = GetPointCenterVerticalOfPanel(FinalSizePanel, child);
            Point Selft = GetPointSelfUIElement(child, RelativeTo); // self position
            return new Point(Selft.X, CenterY.Y);
        }

        private Point GetPointXStartWithCenterOfPanel(Size FinalSizePanel, UIElement child, UIElement RelativeTo)
        {
            Point CenterX = GetPointCenterHorizontalOfPanel(FinalSizePanel, child);
            Point Selft = GetPointSelfUIElement(child, RelativeTo); // self position
            return new Point(CenterX.X, Selft.Y);
        }


        private Point GetPointCenterHorizontalOfPanel(Size FinalSizePanel, UIElement child)
        {
            // Center Horizental
            double helfPanelWidth = FinalSizePanel.Width / 2;
            double helfChildWidth = child.DesiredSize.Width / 2;
            double StartPointWidth = helfPanelWidth - helfChildWidth;
            return new Point(StartPointWidth, 0);
        }


        private Point GetPointCenterVerticalOfPanel(Size FinalSizePanel, UIElement child)
        {
            // Center Vertical
            double helfPanelHeight = FinalSizePanel.Height / 2;
            double helfChildHeight = child.DesiredSize.Height / 2;
            double StartPointHeight = helfPanelHeight - helfChildHeight;
            return new Point(0, StartPointHeight);
        }

        private Point GetPointAboveStartOfWtih(UIElement child, UIElement UIAboveStartOfWtihThis, UIElement RelatedTo)
        {
            Point PointParent = GetPointSelfUIElement(UIAboveStartOfWtihThis, RelatedTo); // UIAboveStartOfWtihThis.TranslatePoint(new Point(0, 0), RelatedTo);
            double Top = PointParent.Y - child.DesiredSize.Height /*- UIAboveStartOfWtihThis.DesiredSize.Height*/;
            double Left = GetPointSelfUIElement(child, RelatedTo).X;
            return new Point(Left, Top);
        }

        private Point GetPointSelfUIElement(UIElement child, UIElement parentPanel) => child.TranslatePoint(new Point(0, 0), parentPanel);

        private Point GetPointAboveLeftOfPanel() => new Point(0, 0);

        private Point GetPointAboveRightOfPanel(Size FinalSizePanel, UIElement child)
        {
            double right = FinalSizePanel.Width - child.DesiredSize.Width;
            return new Point(right, 0);
        }

        private Point GetPointBottomRightOfPanel(Size FinalSizePanel, UIElement child)
        {
            double right = FinalSizePanel.Width - child.DesiredSize.Width;
            double bottom = FinalSizePanel.Height - child.DesiredSize.Height;
            return new Point(right, bottom);
        }

        /// <summary>
        /// کنترل رو پشت کنترل دیگری دیگر می برد
        /// می باشد UIBehindThis موقعیت کنترل مورد نظر تا ابتدای کنترل 
        /// </summary>
        /// <param name="child">کنترلی که موقعیت ش وابست به کنترل UIBehindThis می باشد </param>
        /// <param name="UIBehindThis">کنترلی که، کنترل فرزند موقعیتش رو نبست به آن سنجیده میشود</param>
        /// <param name="RelatedTo">کنترل پنل اصلی که قرار است موقعیت کلی کنترل ها نسبت به آن سنجیده میشود</param>
        /// <returns></returns>
        private Point GetPointBehindOf(UIElement child, UIElement UIBehindThis, UIElement RelatedTo)
        {
            Point point = UIBehindThis.TranslatePoint(new Point(0, 0), RelatedTo);
            double StartPointLeft = point.X - child.DesiredSize.Width;
            return new Point(StartPointLeft, point.Y);
        }

        /// <summary>
        /// کنترل رو پشت کنترل دیگری دیگر می برد
        /// می باشد UIBehindThis موقعیت کنترل مورد نظر تا ابتدای کنترل 
        /// </summary>
        /// <param name="child">کنترلی که موقعیت ش وابست به کنترل UIBehindThis می باشد </param>
        /// <param name="UIBehindThis">کنترلی که، کنترل فرزند موقعیتش رو نبست به آن سنجیده میشود</param>
        /// <param name="RelatedTo">کنترل پنل اصلی که قرار است موقعیت کلی کنترل ها نسبت به آن سنجیده میشود</param>
        /// <returns></returns>
        private Point GetPointBehindYCenterOf(UIElement child, UIElement UIBehindThis, UIElement RelatedTo)
        {
            Point point = UIBehindThis.TranslatePoint(new Point(0, 0), RelatedTo);
            double StartPointLeft = point.X - child.DesiredSize.Width;
            Point centerY = GetPointInsideCenterIn(child, UIBehindThis, RelatedTo);
            return new Point(StartPointLeft, centerY.Y);
        }

        private Point GetPointBehindBottomOf(UIElement child, UIElement parentAttached, BPanel relativePanel)
        {
            Point point = parentAttached.TranslatePoint(new Point(0, 0), relativePanel);
            double StartPointLeft = point.X - child.DesiredSize.Width;

            //double centerY = ParentPoint.Y + UIAboveStartOfWtihThis.DesiredSize.Height - child.DesiredSize.Height;
            Point centerY = GetPointInsideCenterBottomIn(child, parentAttached, relativePanel);

            return new Point(StartPointLeft, centerY.Y);
        }


        /// <summary>
        /// پایین ترین و سمت چپ پنل
        /// </summary>
        /// <param name="FinalSizePanel">ArrangeOverride اندازه پنل در متد</param>
        /// <param name="child">کنترلی که موقعیت ش وابست به کنترل RelativePanel می باشد </param>
        /// <returns></returns>
        private Point GetPointBottomLeftOfPanel(Size FinalSizePanel, UIElement child)
        {
            double BottomLeft = FinalSizePanel.Height - child.DesiredSize.Height;
            return new Point(0, BottomLeft);
        }


    }
}
