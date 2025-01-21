import React from 'react';
import './services.css';

function Services() {
  return (
    <div className="services-container">
      {/* Hero Section */}
      <div className="services-hero">
        <h1>Our Services</h1>
        <p>
          At <strong>Happy Paws Hub</strong>, we offer a variety of services to ensure your pet receives the best care. From regular check-ups to emergency care, we are committed to your pet's health.
        </p>
      </div>

      {/* Services List Section */}
      <div className="services-list">
        <h2>Our Services Include</h2>
        <ul>
          <li>Routine Checkups</li>
          <li>Vaccinations and Preventative Care</li>
          <li>Emergency Veterinary Care</li>
          <li>Pet Grooming Services</li>
          <li>Pet Wellness and Nutrition Advice</li>
        </ul>
      </div>
    </div>
  );
}

export default Services;

