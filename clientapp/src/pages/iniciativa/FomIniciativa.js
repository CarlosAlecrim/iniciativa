import React,{Compontent} from "react";

class FormIniciativa extends React.Component{
    constructor(){
        super();
    }

    render(){
        return(
            <div>
            <h1>Cadastrar Iniciativa</h1>
            <form>
                <div className="form-group">
                <label >Nome:</label>
                <input type="text" name="nome" className="form-control" placeholder="Nome"></input>
                </div>
                <div className="form-group">
                <label>Descrição:</label>
                <input type="text" name="descricao" className="form-control" placeholder="Descrição"></input>
                </div>
                <div className="form-group">
                <label>Imagem:</label>
                <input type="text" name="imagem" className="form-control" placeholder="Imagem"></input>
                </div>
                <div className="form-group">
                <label>Link:</label>
                <input type="text" name="link" className="form-control" placeholder="Link"></input>
                </div>
                
                <button type="button" className="btn btn-primary">Enviar</button>
            </form>
            </div>
        );
    }
}

export default FormIniciativa;