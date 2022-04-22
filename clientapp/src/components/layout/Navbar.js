import React from "react";
import{
BrowserRouter as Router,
Switch,
Route,
Link
} from "react-router-dom"
import Contato from "../../pages/Contato";
import FormEvento from "../../pages/evento/FomEvento";
import Home from "../../pages/Home";
import FormIniciativa from "../../pages/iniciativa/FomIniciativa";

function Navbar(){
    return(
        <Router>
       
            <nav className="navbar navbar-expand-lg  navbar-dark bg-dark">
            <Link className="navbar-brand" to="/">Home</Link>
                <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span className="navbar-toggler-icon"></span>
                </button>

                <div className="collapse navbar-collapse" id="navbarNav">
                    <ul className="navbar-nav">
                        <li className="nav-item" >
                            <Link className="nav-link" to="/iniciativa">Iniciativas</Link>
                        </li>    
                        <li className="nav-item">
                            <Link className="nav-link" to="/eventos">Eventos</Link>
                        </li>
                        <li className="nav-item" >
                            <Link  className="nav-link " to="/sobre">Sobre</Link>
                        </li>

                    </ul>
                </div>
            </nav>
        
        <Switch>
            <Route exact path="/">
                <Home/>
            </Route>
            <Route exact path="/eventos">
                <FormEvento/>
            </Route>
            <Route exact path="/sobre">
                <Contato/>
            </Route>
            <Route exact path="/iniciativa">
                <FormIniciativa/>
            </Route>
        </Switch>
        </Router>
    );
}

export default Navbar;