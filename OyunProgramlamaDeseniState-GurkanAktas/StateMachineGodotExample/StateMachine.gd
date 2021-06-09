

class_name StateMachine
var states

func _init():
	states = {
		"idle": IdleState,
		"walk": WalkState,
		"punch" : PunchState
}

func get_state(state_name):
	if states.has(state_name):
		return states.get(state_name)
	else:
		printerr("No state ", state_name, " in state machine!")
