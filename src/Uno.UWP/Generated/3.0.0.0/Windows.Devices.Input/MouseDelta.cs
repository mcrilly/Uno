#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Input
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct MouseDelta 
	{
		// Forced skipping of method Windows.Devices.Input.MouseDelta.MouseDelta()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  int X;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  int Y;
		#endif
	}
}