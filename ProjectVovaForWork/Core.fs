module Core
//объект имеет размер
//товар - разновидность объекта
//контейнер - разновидность объекта
//
//мешок - разновидность контейнера
//коробка - разновидность контейнера
//полиэтиленовая упаковка - разновидность контейнера
//
//в контейнер можно поместить множество товаров
//
//существуют контейнеры которые плотно помещают в себя какое-то количество определенного товара, т.н. заводские контейнеры
//
//поддон - разновидность объекта
//стеллаж - разновидность объекта
//
//стеллаж состоит из множества полок, с разным расстоянием друг от друга
//
//склад имеет форму параллелепипеда
//коробка имеет форму параллелепипеда
//один и тот же тип товара может иметь разные штрих-коды
type Size = 
    | Undefined
    | Size of int * int * int
type Position = Pos of int * int * int
type Rotate = bool

type TypeCont = Box | Bag | Other
type Good = { Name:string; BarCode:int; Size:Size; Type:TypeCont }

type TypeClosely = 
    | NotClosely
    /// расположение товара: количество по ширине, по длине и по высоте.
    | PackClosely of int * int * int
//type LabelLoc = Top | Side | NotExist
/// Коробка, в котором привозят определенное количество однотипного товара. Если товар коробочного типа, и товар в коробке располагается без зазоров, то вместимость такой коробки определяется как кол-во по ширине * кол-во по длине * кол-во по высоте товара.
type Container = {
//    LabelLoc:LabelLoc
    TypeClosely:TypeClosely
    Type:TypeCont
    Good:Good
    Count:int
    Size:Size }
// как при создании контейнера определить где его ширина, а где длина? Этикетка с характеристиками содержимого не показательна: на одном и том же типе контейнера, ее могут наклеить на разные стороны. Предлагаю определять самую широкую часть как ширину (расположить в доль ворот), самую узкую как длину, третью сторону - высоту. Если в коробке товар жидкого типа и он расположен вдоль длинной стороны пробкой к потолку, то такую сторону наречь высотой и рассматривать остальные две стороны. Если коробка расположена вдоль дверей "длиной" своей стороной - значит она повернута на 90 градусов.
type ContainerState = 
    | Closed
    | Opened of (Good * int) list

//type Container = { Contai:Contai; State:ContainerState }
type Object =
    | Container of Container * ContainerState
    | Good of Good
type Warehouse = Warehouse of (Object * Position * Rotate) list


// способы создания:
// в таком-то месте стоит полная упаковка, начиненная n количеством однотипового товара g
// например, есть коробка 4 "Сульсен шампунь" в (0,0,0) координатах

let shampooSulsen = { Name = "Шампунь Сульсен"; BarCode = 329; Size = Undefined; Type = Box }
let boxShampooSulsen = {
    Type = Box
    Good = shampooSulsen
    Count = 4
    Size = Size(300, 300, 100)
    TypeClosely = PackClosely(2,2,1)
    //LabelLoc = Top 
    }
//let f good = 
//    if goodNotDefSize good then
//        if goodBoxType good then
//            match tryfindContForGood good with
//            | Some cont -> 
//                if isGoodPackcloselyInCont good cont then
//                    let Place(xC,yC,zC) = cont.TypeClosely
//                    let Size(x, y, z) = cont.Size
//                    Some <| Size(x/xC, y/yC, z/zC)
//                else None
//            | None -> None
//        else None
//    else None

let seaSilt = {
    Name = "Морская соль 700г"
    BarCode = 560
    Size = Undefined
    Type = Bag }
let seaSiltBag = {
    Type = Bag
    TypeClosely = NotClosely
    Good = seaSilt
    Count = 10
    Size = Undefined
    //LabelLoc = failwith "Not implemented yet"
    }

let warehouse = 
    Warehouse[
        Container(boxShampooSulsen, Closed), Pos(0, 0, 0), false
        Good shampooSulsen, Pos(10, 20, 0), false
        Good seaSilt, Pos(30, 100, 0), false
        Container(seaSiltBag, Opened [seaSilt, 8]), Pos(400, 400, 0), false
        ]

type Inter () =
    let mutable lst = []
    static member Size(x, y, z) = Size(x, y, z)
    static member Size() = Undefined
    member __.AddGood name barcode size typ = 
        lst <- { Name = name
                 BarCode = barcode
                 Size = size
                 Type = typ } :: lst
//    member __.Add x = ()
//type Err = 
//    | InputName
//    | Done
//let add inputName = 
//    if inputName = "" then InputName
//    elif inputBarcode
//    Done

Inter.Size()
let core = new Inter()
core.AddGood "хна" 124 <| Inter.Size()

//Inter.Size(10, 20, 30)
let createGood name barcode size typ =
    ()


//[<EntryPoint>]
//let main argv = 
//    printfn "%A" argv
//    0 // return an integer exit code
