﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Xamarin.Forms.Core.UITests
{	
	internal static class GalleryQueries
	{
		public const string AutomationIDGallery = "* marked:'AutomationID Gallery'";
		public const string ActivityIndicatorGallery = "* marked:'ActivityIndicator Gallery'";
		public const string BoxViewGallery = "* marked:'BoxView Gallery'";
		public const string ButtonGallery = "* marked:'Button Gallery'";
		public const string ContextActionsListGallery = "* marked:'ContextActions List Gallery'";
		public const string ContextActionsTableGallery = "* marked:'ContextActions Table Gallery'";
		public const string DatePickerGallery = "* marked:'DatePicker Gallery'";
		public const string EditorGallery = "* marked:'Editor Gallery'";
		public const string EntryGallery = "* marked:'Entry Gallery'";
		public const string FrameGallery = "* marked:'Frame Gallery'";
		public const string ImageGallery = "* marked:'Image Gallery'";
		public const string LabelGallery = "* marked:'Label Gallery'";
		public const string ListViewGallery = "* marked:'ListView Gallery'";
		public const string OpenGLViewGallery = "* marked:'OpenGLView Gallery'";
		public const string PickerGallery = "* marked:'Picker Gallery'";
		public const string ProgressBarGallery = "* marked:'ProgressBar Gallery'";
		public const string ScrollViewGallery = "* marked:'ScrollView Gallery'";
		public const string ScrollViewGalleryHorizontal = "* marked:'ScrollView Gallery Horizontal'";
		public const string SearchBarGallery = "* marked:'SearchBar Gallery'";
		public const string SliderGallery = "* marked:'Slider Gallery'";
		public const string StepperGallery = "* marked:'Stepper Gallery'";
		public const string SwitchGallery = "* marked:'Switch Gallery'";
		public const string TableViewGallery = "* marked:'TableView Gallery'";
		public const string TimePickerGallery = "* marked:'TimePicker Gallery'";
		public const string WebViewGallery = "* marked:'WebView Gallery'";
		public const string ToolbarItemGallery = "* marked:'ToolbarItems Gallery'";
		public const string DisplayAlertGallery = "* marked:'DisplayAlert Gallery'";
		public const string ActionSheetGallery = "* marked:'ActionSheet Gallery'";
		public const string RootPagesGallery = "* marked:'RootPages Gallery'";

		public const string AppearingGallery = "* marked:'Appearing Gallery'";

		// Legacy galleries
		public const string AbsoluteLayoutGalleryLegacy = "* marked:'AbsoluteLayout Gallery - Legacy'";
		public const string BoundPageGalleryLegacy = "* marked:'BoundPage Gallery - Legacy'";
		public const string ButtonGalleryLegacy = "* marked:'Button Gallery - Legacy'";
		public const string CellsGalleryLegacy = "* marked:'Cells Gallery - Legacy'";
		public const string CarouselPageGalleryLegacy = "* marked:'CarouselPage Gallery - Legacy'";
		public const string ClipToBoundsGalleryLegacy = "* marked:'ClipToBounds Gallery - Legacy'";
		public const string EditorGalleryLegacy = "* marked:'Editor Gallery - Legacy'";
		public const string EntryGalleryLegacy = "* marked:'Entry Gallery - Legacy'";
		public const string GridGalleryLegacy = "* marked:'Grid Gallery - Legacy'";
		public const string GroupedListActionsGalleryLegacy = "* marked:'GroupedListActions Gallery - Legacy'";
		public const string GroupedListGalleryLegacy = "* marked:'GroupedList Gallery - Legacy'";
		public const string InputIntentGalleryLegacy = "* marked:'InputIntent Gallery - Legacy'";
		public const string ListViewGalleryLegacy = "* marked:'ListView Gallery - Legacy'";
		public const string MapGalleryLegacy = "* marked:'Map Gallery - Legacy'";
		public const string MinimumSizeGalleryLegacy = "* marked:'MinimumSize Gallery - Legacy'";
		public const string NavigationBarGalleryLegacy = "* marked:'NavigationBar Gallery - Legacy'";
		public const string RelativeLayoutGalleryLegacy = "* marked:'RelativeLayout Gallery - Legacy'";
		public const string SearchBarGalleryLegacy = "* marked:'SearchBar Gallery - Legacy'";
		public const string SliderGalleryLegacy = "* marked:'Slider Gallery - Legacy'";
		public const string StackLayoutGalleryLegacy = "* marked:'StackLayout Gallery - Legacy'";
		public const string StepperGalleryLegacy = "* marked:'Stepper Gallery - Legacy'";
		public const string SwitchGalleryLegacy = "* marked:'Switch Gallery - Legacy'";
		public const string TableViewGalleryLegacy = "* marked:'TableView Gallery - Legacy'";
		public const string TemplatedCarouselPageGalleryLegacy = "* marked:'TemplatedCarouselPage Gallery - Legacy'";
		public const string TemplatedTabbedPageGalleryLegacy = "* marked:'TemplatedTabbedPage Gallery - Legacy'";
		public const string ToolbarGalleryLegacy = "* marked:'Toolbar Gallery - Legacy'";
		public const string UnevenViewCellGalleryLegacy = "* marked:'UnevenViewCell Gallery - Legacy'";
		public const string UnevenListGalleryLegacy = "* marked:'UnevenList Gallery - Legacy'";
		public const string ViewCellGalleryLegacy = "* marked:'ViewCell Gallery - Legacy'";
	}

	internal static class Queries
	{
		#region Shared queries 
		public static Func<AppQuery, AppQuery> RootPageListView = PlatformQueries.RootPageListView; 
		public static Func<AppQuery, AppQuery> GalleryListView = PlatformQueries.GalleryListView; 

		public static Func<AppQuery, AppQuery> ButtonWithText (string text)
		{
			return q => q.Button (text);
		}

		public static Func<AppQuery, AppQuery> ElementWithText (string text)
		{
			return q => q.Marked (text);
		}

		public static Func<AppQuery, AppQuery> All ()
		{
			return q => q.All ();
		}

		#endregion

		#region Platform queries

		public static Func<AppQuery, AppQuery> NavigationBarBackButton ()
		{
			return PlatformQueries.NavigationBarBackButton;
		}

		public static Func<AppQuery, AppQuery> PageWithoutNavigationBar ()
		{
			return PlatformQueries.PageWithoutNavigationBar;
		}

		public static Func<AppQuery, AppQuery> Root ()
		{
			return PlatformQueries.Root;
		}

		public static Func<AppQuery, AppQuery> EntryCellWithPlaceholder (string placeholder)
		{
			return PlatformQueries.EntryCellWithPlaceholder (placeholder);
		} 

		public static Func<AppQuery, AppQuery> EntryCellWithText (string placeholder)
		{
			return PlatformQueries.EntryCellWithText (placeholder);
		} 

		#endregion

	}

	internal static class Views
	{
		public static readonly string ActivityIndicator = PlatformViews.ActivityIndicator;
		public static readonly string BoxView = PlatformViews.BoxView;
		public static readonly string Button = PlatformViews.Button;
		public static readonly string DatePicker = PlatformViews.DatePicker;
		public static readonly string Editor = PlatformViews.Editor;
		public static readonly string Entry = PlatformViews.Entry;
		public static readonly string Frame = PlatformViews.Frame;
		public static readonly string Image = PlatformViews.Image;
		public static readonly string Label = PlatformViews.Label;
		public static readonly string ListView = PlatformViews.ListView;
		public static readonly string OpenGLView = PlatformViews.OpenGLView;
		public static readonly string Picker = PlatformViews.Picker;
		public static readonly string ProgressBar = PlatformViews.ProgressBar;
		public static readonly string SearchBar = PlatformViews.SearchBar;
		public static readonly string Slider = PlatformViews.Slider;
		public static readonly string Stepper = PlatformViews.Stepper;
		public static readonly string Switch = PlatformViews.Switch;
		public static readonly string TableView = PlatformViews.TableView;
		public static readonly string TimePicker = PlatformViews.TimePicker;
		public static readonly string WebView = PlatformViews.WebView;
	}

	internal static class Rects
	{
		public static AppRect RootViewRect (this IApp app)
		{
			return app.Query (q => q.Raw ("* index:0"))[0].Rect;
		}
	}
}
