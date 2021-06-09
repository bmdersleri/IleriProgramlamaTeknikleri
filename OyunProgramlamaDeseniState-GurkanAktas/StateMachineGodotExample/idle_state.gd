extends State

class_name IdleState

func _ready():
	animated_sprite.play("idle")


func _flip_direction():
	animated_sprite.flip_h = not animated_sprite.flip_h

func _physics_process(delta):
	if Input.is_action_just_pressed("A"):
		change_state.call_func("punch")

func move_left():
	if animated_sprite.flip_h:
		change_state.call_func("walk")
	else:
		_flip_direction()

func move_right():
	if not animated_sprite.flip_h:
		change_state.call_func("walk")
	else:
		_flip_direction()
