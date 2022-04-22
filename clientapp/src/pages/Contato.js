import React, {Component} from "react";

class Contato extends React.Component{
    constructor(){
        super();
    }

    render(){
        return(
            <section>
                <h1>Carlos</h1>
                <p>Acesse meu <a href="http://www.google.com">Github:</a></p>
            </section>
        );
    }
}

export default Contato