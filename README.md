# Instructions for the Code Review Test

Imagine you are a developer at Playa3ull, tasked with reviewing a project submitted by a candidate applying for the Senior Unity Developer position.

You are receiving a complete project created by the candidate. Your job is to perform a thorough code review. You are NOT required to write any code or make enhancements to the project. Instead, document your feedback directly as comments within the code, similar to how you would in a Pull Request.

The purpose of this exercise is to evaluate your coding style, analytical skills, and ability to provide constructive feedback—without requiring extensive time spent coding.

Here are some recommended strategies for approaching the assessment:

 1. Analyze Holistically. Review the project from multiple perspectives, such as architecture, performance, programmer’s knowledge and approach, documentation and code readability, code quality and maintainability, project organisation.
 2. Take note of both positive and negative aspects of the code, regardless of their size or importance.
 3. Propose suggestions for improvements, focusing on practical considerations rather than solely on code elegance. Evaluate the potential effort required to implement the changes and their overall benefits, as if it were a real-world project.
 4. Run the project to identify bugs or issues. Verify whether it meets all listed requirements.

## Submission

Return the project with your comments included, or alternatively, upload the project to GitHub and create a Pull Request.

## Project Description and Requirements

These are the instructions used to implement the project you are reviewing:

The project is a deterministic simulation with a “real-time” visualization of a board game where units move and attack each other. 

 - The simulation takes place on a hex grid (approximately 101 hexes wide by 101 hexes tall, but the exact number is not yet defined).
 - Units walk between hexes in the simulation at some fixed rate of hexes per Time Step.
 - Two units (a red ball and a blue ball) must start on random hex tiles.
 - They must move towards each other using some basic pathing. In the simulation they must only ever be on a discrete hex. In the visualisation they can lerp between.
 - Once within some defined range of your choosing (measured in hex tiles), they must begin to attack one another at some defined rate of Time Steps per attack.
 - The balls should receive some random number of ‘hit points’ between 2 and 5. This decides how many attacks they can take before dying.
 - The simulation must be deterministic.
 - Add extra Blue and Red balls to the battle. They should target the closest ball of the opposite colour.
 - Don't worry about the visual aspect of the simulation; the simulation, code and architecture are the important points.
 
Information about hex grid implementations can be found at https://www.redblobgames.com/grids/hexagons/ 

Thank you for dedicating your time to this process. We appreciate your interest in joining our team!
