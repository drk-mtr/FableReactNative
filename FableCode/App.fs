namespace FableCode
open Feliz
open Fable
open Elmish
open Fable.ReactNative
open Fable.ReactNative.Props

module App = 

    [<ReactComponent>]
    let AppFable() = 

        let (count, setCount) = React.useState(0)

        view [] [
            text [] ("Count is: " + string count)

            button [ ButtonProperties.OnPress (fun _ -> setCount(count + 1)); ButtonProperties.Title "Increment" ] []
            button [ ButtonProperties.OnPress (fun _ -> setCount(count - 1)); ButtonProperties.Title "Decrement" ] []
        ]
        