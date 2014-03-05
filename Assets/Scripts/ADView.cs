using UnityEngine;
using System.Collections;

public class ADView :MonoBehaviour
{
	public ADBannerView banner = null;
	public bool isBannerLoaded = false;

	void Start()
	{
		banner = new ADBannerView(ADBannerView.Type.Banner, ADBannerView.Layout.Bottom);
		ADBannerView.onBannerWasClicked += OnBannerClicked;
		ADBannerView.onBannerWasLoaded  += OnBannerLoaded;
		Object.DontDestroyOnLoad(transform.gameObject);
	}

	void OnBannerClicked()
	{
		Debug.Log("Clicked!\n");
	}

	void OnBannerLoaded()
	{
		Debug.Log("Loaded!\n");
		isBannerLoaded = true;
	}

	public void showBanner(bool isshow)
	{
		Debug.Log("isBannerLoaded\n"+isBannerLoaded);
		if(isBannerLoaded)
		{
			banner.visible = isshow;
		}
	}
}