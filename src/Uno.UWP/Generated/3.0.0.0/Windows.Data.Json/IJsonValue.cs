#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Data.Json
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IJsonValue 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Data.Json.JsonValueType ValueType
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.Data.Json.IJsonValue.ValueType.get
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		string Stringify();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		string GetString();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		double GetNumber();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool GetBoolean();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Data.Json.JsonArray GetArray();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Data.Json.JsonObject GetObject();
		#endif
	}
}
