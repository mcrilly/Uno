#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Input.Preview
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GazeEnteredPreviewEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool GazeEnteredPreviewEventArgs.Handled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Input.Preview.GazeEnteredPreviewEventArgs", "bool GazeEnteredPreviewEventArgs.Handled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Input.Preview.GazePointPreview CurrentPoint
		{
			get
			{
				throw new global::System.NotImplementedException("The member GazePointPreview GazeEnteredPreviewEventArgs.CurrentPoint is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Input.Preview.GazeEnteredPreviewEventArgs.Handled.get
		// Forced skipping of method Windows.Devices.Input.Preview.GazeEnteredPreviewEventArgs.Handled.set
		// Forced skipping of method Windows.Devices.Input.Preview.GazeEnteredPreviewEventArgs.CurrentPoint.get
	}
}
