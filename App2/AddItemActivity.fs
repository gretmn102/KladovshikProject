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

type AddItemFragment() =
    inherit Fragment()
    override this.OnCreateView(inflater, container, savedInstanceState) =
        base.OnCreateView (inflater, container, savedInstanceState) |> ignore

        let view = inflater.Inflate (Resource_Layout.AddItem, container, false);
        let gridSize = view.FindViewById<GridLayout> Resource_Id.gridLayout1
        let radioGroup = view.FindViewById<RadioGroup> Resource_Id.radioGroup1

        let showMessage = 
            let alb = new AlertDialog.Builder(this.Context)
            let alb = alb.Create()
            let f = new EventHandler<DialogClickEventArgs>(fun _ _ -> ())
            alb.SetButton("Ok",  f)
            fun (str:string) -> alb.SetMessage str; alb.Show()

        radioGroup.CheckedChange.Add(fun x -> 
            let enable b = Seq.init gridSize.ChildCount id |> Seq.iter (gridSize.GetChildAt >> fun x -> x.Enabled <- b)
            if radioGroup.CheckedRadioButtonId = Resource_Id.rbDefSize then enable true
            else enable false)
        
        //let sampleTextView = view.FindViewById<TextView> (Resource_Id.sampleTextView)
        //sampleTextView.Text <- "sample fragment text"
        let nameInput = view.FindViewById<EditText> Resource_Id.txtGoodName
        let barcodeInput = view.FindViewById<EditText> Resource_Id.txtBarcode
        let btnAdd = view.FindViewById<Button> Resource_Id.btnAddItem
        let typeChoicer = view.FindViewById<RadioGroup> Resource_Id.typeChoicer
        let widthInput = view.FindViewById<EditText> Resource_Id.txtWidth
        let lengthInput = view.FindViewById<EditText> Resource_Id.txtLength
        let heightInput = view.FindViewById<EditText> Resource_Id.txtHeight
        let inter = new Core.Inter()
        btnAdd.Click.Add(fun _ -> 
            if nameInput.Text <> "" then
                //nameInput.Error <- ""
                if barcodeInput.Text <> "" then
                    //barcodeInput.Error <- ""
                    let typ =
//                        let x = typeChoicer.CheckedRadioButtonId
//                        if x = Resource_Id.rbBox then Core.Box
//                        elif x = Resource_Id.rbBag then Core.Bag
//                        elif x = Resource_Id.rbOther then Core.Other
//                        else failwithf "incomplite at %A" x
                        match typeChoicer.CheckedRadioButtonId with
                        | x when x = Resource_Id.rbBox -> Core.Box
                        | x when x = Resource_Id.rbBag -> Core.Bag
                        | x when x = Resource_Id.rbOther -> Core.Other
                        | x -> failwithf "incomplite at %A" x
                    let f size = inter.AddGood nameInput.Text (int barcodeInput.Text) size typ
                    if radioGroup.CheckedRadioButtonId = Resource_Id.rbUndefinedSize then
                        f Core.Undefined
                        |> sprintf "%A" |> showMessage
                    elif widthInput.Text <> "" && lengthInput.Text <> "" && heightInput.Text <> "" then
                        f <| Core.Size(int widthInput.Text, int lengthInput.Text, int heightInput.Text)
                        |> sprintf "%A" |> showMessage
                else barcodeInput.Error <- "is empty"
            else nameInput.Error <- "is empty"
            ())
        view