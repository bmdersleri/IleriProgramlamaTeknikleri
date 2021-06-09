extends State

class_name PunchState

func _ready():
	animated_sprite.play("punch")
	
func _physics_process(delta):
	if animated_sprite.frame >= 6:
		change_state.call_func("idle")
