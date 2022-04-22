import React from 'react'
import ReactDom from 'react-dom'
import Navbar from './components/layout/Navbar';
import Footer from './components/layout/Footer'


function Main(props){
  return (
  <div className="container">
    <Navbar/>
  <div className="container">
  

  
  </div>
  <Footer />
  </div>
  );
}



ReactDom.render(<Main/>,document.getElementById('root'));
