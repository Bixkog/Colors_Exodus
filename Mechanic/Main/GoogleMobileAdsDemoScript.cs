using System;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System.Collections;

// Example script showing how to invoke the Google Mobile Ads Unity plugin.
public class GoogleMobileAdsDemoScript : MonoBehaviour
{
	public InterstitialAd interstitial;
	private static GoogleMobileAdsDemoScript instance;

	void Awake()
	{
			if (instance == null)
						instance = this;
				else
						Destroy (this.gameObject);
				DontDestroyOnLoad (this.gameObject);
	}

	void Start()
	{
				if (Options.instance.data.ads) {
						CreateInterstitial ();
						RequestInterstitial ();
				}
		}


	public void Ads()
	{
		if(Options.instance.data.ads)ShowInterstitial();
	}

	public void CreateInterstitial()
	{
				#if UNITY_EDITOR
		string adUnitId = "unused";
				#elif UNITY_ANDROID
		string adUnitId = "ca-app-pub-3135839138764456/8419587724";
				#elif UNITY_IPHONE
		string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
				#else
				string adUnitId = "unexpected_platform";
				#endif
		
				// Create an interstitial.
				interstitial = new InterstitialAd (adUnitId);
		}
	

	public void RequestInterstitial()
	{
		// Load an interstitial ad.
		interstitial.LoadAd(new AdRequest.Builder().Build());
		print ("loaded");
	}
	
	// Returns an ad request with custom ad targeting.
	private AdRequest createAdRequest()
	{
		return new AdRequest.Builder()
			.AddTestDevice(AdRequest.TestDeviceSimulator)
				.AddTestDevice("0123456789ABCDEF0123456789ABCDEF")
				.AddKeyword("game")
				.SetGender(Gender.Male)
				.SetBirthday(new DateTime(1985, 1, 1))
				.TagForChildDirectedTreatment(false)
				.AddExtra("color_bg", "9B30FF")
				.Build();
		
	}
	
	private void ShowInterstitial()
	{
		if (interstitial.IsLoaded())
		{
			interstitial.Show();
		}
		else
		{
			print("Interstitial is not ready yet.");
		}
	}


}