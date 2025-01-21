import React from 'react';
import './home.css';

function Home() {
  return (
    <div className="home-container">
      <div className="hero-section">
        
        <div className="hero-content">
          <h1>Welcome to Happy Paws Hub</h1>
          <p>Your all-in-one solution for pet care and health management.</p>
        </div>
      </div>

      <div className="features-section">
        <h2>Why Choose Us?</h2>
        <div className="features-grid">
          <div className="feature-card">
            <h3>Appointment Scheduling</h3>
            <p>Book and manage appointments with ease.</p>
          </div>
          <div className="feature-card">
            <h3>Medical Records</h3>
            <p>Access all your pet's medical history in one place.</p>
          </div>
          <div className="feature-card">
            <h3>Notifications</h3>
            <p>Get reminders for vaccinations and check-ups.</p>
          </div>
        </div>
      </div>
    </div>
  );
}
export default Home;