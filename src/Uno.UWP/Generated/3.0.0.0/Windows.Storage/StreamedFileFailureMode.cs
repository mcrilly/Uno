#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum StreamedFileFailureMode 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Failed,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		CurrentlyUnavailable,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Incomplete,
		#endif
	}
	#endif
}
