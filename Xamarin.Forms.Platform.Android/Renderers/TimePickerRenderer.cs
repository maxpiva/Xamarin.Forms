using System;
using System.ComponentModel;
using Android.App;
using Android.Widget;
using ADatePicker = Android.Widget.DatePicker;
using ATimePicker = Android.Widget.TimePicker;
using Object = Java.Lang.Object;

namespace Xamarin.Forms.Platform.Android
{
	public class TimePickerRenderer : ViewRenderer<TimePicker, EditText>, TimePickerDialog.IOnTimeSetListener
	{
		AlertDialog _dialog;

		public TimePickerRenderer()
		{
			AutoPackage = false;
		}

		void TimePickerDialog.IOnTimeSetListener.OnTimeSet(ATimePicker view, int hourOfDay, int minute)
		{
			((IElementController)Element).SetValueFromRenderer(VisualElement.IsFocusedPropertyKey, false);

			((IElementController)Element).SetValueFromRenderer(TimePicker.TimeProperty, new TimeSpan(hourOfDay, minute, 0));
			Control.ClearFocus();
			_dialog = null;
		}

		protected override void OnElementChanged(ElementChangedEventArgs<TimePicker> e)
		{
			base.OnElementChanged(e);

			if (e.OldElement == null)
			{
				var textField = new EditText(Context) { Focusable = false, Clickable = true, Tag = this };

				textField.SetOnClickListener(TimePickerListener.Instance);
				SetNativeControl(textField);
			}

			SetTime(e.NewElement.Time);
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName == TimePicker.TimeProperty.PropertyName || e.PropertyName == TimePicker.FormatProperty.PropertyName)
				SetTime(Element.Time);
		}

		internal override void OnFocusChangeRequested(object sender, VisualElement.FocusRequestArgs e)
		{
			base.OnFocusChangeRequested(sender, e);

			if (e.Focus)
				OnClick();
			else if (_dialog != null)
			{
				_dialog.Hide();
				((IElementController)Element).SetValueFromRenderer(VisualElement.IsFocusedPropertyKey, false);
				Control.ClearFocus();
				_dialog = null;
			}
		}

		void OnClick()
		{
			TimePicker view = Element;
			((IElementController)Element).SetValueFromRenderer(VisualElement.IsFocusedPropertyKey, true);

			_dialog = new TimePickerDialog(Context, this, view.Time.Hours, view.Time.Minutes, false);
			_dialog.Show();
		}

		void SetTime(TimeSpan time)
		{
			Control.Text = DateTime.Today.Add(time).ToString(Element.Format);
		}

		class TimePickerListener : Object, IOnClickListener
		{
			public static readonly TimePickerListener Instance = new TimePickerListener();

			public void OnClick(global::Android.Views.View v)
			{
				var renderer = v.Tag as TimePickerRenderer;
				if (renderer == null)
					return;

				renderer.OnClick();
			}
		}
	}
}