// App.js
import React, { useState } from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Header from './component/Header';
import Wrapper from './component/Wrapper';
import Home from './pages/Home';
import About from './pages/About';
import Services from './pages/Services';
import Contact from './pages/Contact';
import AppointTable from './component/AppointTable';
import AddAppointment from './component/AddAppointment';
import EditAppoinment from './component/EditAppoinment';
import LoginForm from './component/LoginForm';

import './App.css';

function App() {
  const [isPopupActive, setIsPopupActive] = useState(false);

  return (
    <Router>
      
      <div className="App">
        <Routes>
          {/* Authentication */}
          <Route path="/login" element={<LoginForm />} />

          {/* Appoinment Management */}
          <Route path="/appointment/table" element={<AppointTable />} />
          <Route path="/edit/appointment/:productCode" element={<EditAppoinment />} />
          <Route path="/create/appointment" element={<AddAppointment />} />

          {/* Main Layout */}
          <Route
            path="*"
            element={
              <>
              
                <Header onLoginClick={() => setIsPopupActive(true)} />
                {isPopupActive && (
                  <Wrapper
                    isPopupActive={isPopupActive}
                    onClose={() => setIsPopupActive(false)}
                  />
                )}
                <Routes>
                  <Route path="/" element={<Home />} />
                  <Route path="/about" element={<About />} />
                  <Route path="/services" element={<Services />} />
                  <Route path="/contact" element={<Contact />} />
                </Routes>
                
              </>
            }
          />
          
        </Routes>
        
      </div>
      
    </Router>
    
  );
}

export default App;
