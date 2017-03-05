namespace App2

open System

open Android.App
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget

[<Activity (Label = "App2", MainLauncher = true)>]
type MainActivity () =
    inherit Activity ()
    override this.OnCreate (bundle) =
        base.OnCreate (bundle)
        this.SetContentView (Resource_Layout.Main)
        this.ActionBar.NavigationMode <- ActionBarNavigationMode.Tabs
        let createTab (text:string) (fragment:Fragment) =
            let tab = this.ActionBar.NewTab()
            tab.SetText text |> ignore
            tab.TabSelected.Add(fun e ->
                e.FragmentTransaction.Add(Resource_Id.frameLayout1, fragment) |> ignore)
            this.ActionBar.AddTab tab
            tab.TabUnselected.Add(fun e -> e.FragmentTransaction.Remove fragment |> ignore)

        createTab "addItem" <| new AddItemFragment ()
        createTab "add item to warehouse" <| new AddItemOnWarehouseFragment ()

//        let tabHost = this.FindViewById<TabHost> Resource_Id.tabHost1
//        tabHost.Setup()
//        
//        let spec = tabHost.NewTabSpec "Tab1" |> fun x -> x.SetIndicator "Tab1" |> fun x -> x.SetContent Resource_Layout.AddItem
//        tabHost.AddTab spec
//
//        tabHost.NewTabSpec "Tab2"
//        |> fun x -> x.SetIndicator "Tab2"
//        |> fun x -> x.SetContent Resource_Layout.AddItemOnWarehouse
//        |> tabHost.AddTab
        ()