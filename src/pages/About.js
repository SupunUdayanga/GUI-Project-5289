import React from 'react';
import './about.css';

function About() {
  return (
    <div className="about-container">
      {/* Hero Section */}
      <div className="about-hero">
        <h1>About Us</h1>
        <p>
          At <strong>Happy Paws Hub</strong>, we are dedicated to providing comprehensive solutions for pet care management. From appointment scheduling to maintaining medical records, we are your trusted partner in ensuring your pet's health and happiness.
        </p>
      </div>

      {/* Mission Section */}
      <div className="about-mission">
        <h2>Our Mission</h2>
        <p>
          Our mission is to simplify pet care for pet owners and veterinarians alike by offering a seamless, user-friendly platform. We believe in leveraging technology to improve the well-being of pets everywhere.
        </p>
      </div>
    </div>
  );
}

export default About;
