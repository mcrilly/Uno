#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Inking
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IInkPresenterRulerFactory 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.UI.Input.Inking.InkPresenterRuler Create( global::Windows.UI.Input.Inking.InkPresenter inkPresenter);
		#endif
	}
}
