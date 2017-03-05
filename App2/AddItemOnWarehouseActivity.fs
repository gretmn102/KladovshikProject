namespace App2

open System
open System.Collections.Generic
open System.Linq
open System.Text

open Android.App
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget

//[<Activity (Label = "AddItemOnWarehouseActivity")>]
//type AddItemOnWarehouseActivity () =
//  inherit Activity()
//
//  override this.OnCreate(bundle) =
//    base.OnCreate (bundle)
//    this.SetContentView Resource_Layout.AddItemOnWarehouse
//

type AddItemOnWarehouseFragment() =
    inherit Fragment()
    override this.OnCreateView(inflater, container, savedInstanceState) =
        base.OnCreateView (inflater, container, savedInstanceState) |> ignore

        let view = inflater.Inflate (Resource_Layout.AddItemOnWarehouse, container, false);

        //let sampleTextView = view.FindViewById<TextView> (Resource_Id.sampleTextView)
        //sampleTextView.Text <- "sample fragment text"

        view