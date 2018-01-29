# Curvature
Curvature is a full-featured Utility-based AI editor and sandbox tool.

The project provides a complete playground for creating, editing, and testing decision-making AI. Under the hood, Curvature uses *Utility Theory* to model the appeal of various behaviors. Specifically, Curvature is based on the Infinite Axis Utility System by Dave Mark. Curvature builds on the IAUS approach and includes enhancements and refinements developed during work on *Guild Wars 2: Heart of Thorns* as well as *Guild Wars 2: Path of Fire*.

Curvature is fully data-driven and supports the creation of a complete AI pipeline, from the core knowledge-base accessed by agents, to the specific *considerations* that drive the scoring of individual behaviors. The result is an end-to-end solution for modeling and testing AI, including a simple world representation that allows designers or AI programmers to place agents in a virtual space and see how they would choose to behave.

For complete project documentation, please see [the Curvature wiki](https://github.com/apoch/curvature/wiki).

# Screenshots
![An example behavior being edited in Curvature](https://raw.githubusercontent.com/apoch/curvature/master/Images/Screenshots/Tabs-Behaviors-Scoring.png)
![A scenario set up to demonstrate basic chase AI in Curvature](https://raw.githubusercontent.com/apoch/curvature/master/Images/Screenshots/Tabs-Scenarios-Simulation.png)

# Project Status
Curvature is currently in an open beta testing phase. Check the [project releases page](https://github.com/apoch/curvature/releases) for the latest version of the tool suite.

Existing features of Curvature:
 * Design a *knowledge-base* to contain your world representation and data
 * Select knowledge-base entries to assemble a list of *inputs* that can drive decision-making
 * Pair an input with a decision using a *consideration*, which can control the relevance of the input via *response curves*
 * Collect considerations to make up a *behavior* which represents a discrete choice available to an AI agent
 * Group behaviors into *behavior sets* for easy categorization and bundling of related activities
 * Choose which behavior sets will be enacted for a given *archetype* of AI agent
 * Place AI agents in a sandbox world and watch them make decisions using *scenarios*
 * Response curves and considerations can be constructed with a simple wizard-style helper
 * Running scenarios will log the decisions made by each agent at each "tick" so you can review how things came about
 
More fine-grained information on project plans can be found in the [issue tracker](https://github.com/apoch/curvature/issues).

Overviews of releases and other high-level planning can be found in the [project tracker](https://github.com/apoch/curvature/projects).
