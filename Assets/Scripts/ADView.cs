using UnityEngine;
using System.Collections;

public class ADView :MonoBehaviour
{
	private ADBannerView banner = null;

	void Start()
	{
		banner = new ADBannerView(ADBannerView.Type.Banner, ADBannerView.Layout.Top);
		ADBannerView.onBannerWasClicked += OnBannerClicked;
		ADBannerView.onBannerWasLoaded  += OnBannerLoaded;
	}

	void OnBannerClicked()
	{
		Debug.Log("Clicked!\n");
	}

	void OnBannerLoaded()
	{
		Debug.Log("Loaded!\n");
		banner.visible = true;
	}
}