import React from 'react';
import ReactDOM from 'react-dom';
import "./style.css"

/////////////////////////// Primjer state-ova u funkcijskoj komponenti

// // function App() {
// //     /*const [things, setThings] = React.useState(["Thing 1", "Thing 2"])
    
// //     function addItem() {
// //         const newThingText = `Thing ${things.length + 1}`
// //         setThings(prevState => [...prevState, newThingText])
// //     }
    
// //     const thingsElements = things.map(thing => <p key={thing}>{thing}</p>)
    
// //     return (
// //         <div>
// //             <button onClick={addItem}>Add Item</button>
// //             {thingsElements}
// //         </div>
// //     )
// //     */
   
// }
// ReactDOM.render(<App />, document.getElementById("root"));

/////////////////////////// Primjer state-ova u class komponenti

class Thing extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      things: ["Thing 1", "Thing 2"]
    };
    this.addItem = this.addItem.bind(this);
  }

    addItem() {
        this.setState((prevState) => { 
        return {
        things: [...prevState.things, `Thing ${this.state.things.length + 1}`]
      };
    });
  }

    render() {
        const thingsElements = this.state.things.map(thing => <p key={thing}>{thing}</p>)

        return (
            <div>
                <button onClick={this.addItem}>Add Item</button>
                {thingsElements}             
            </div>
        );
    }
}

ReactDOM.render(<Thing />, document.getElementById("root"));


