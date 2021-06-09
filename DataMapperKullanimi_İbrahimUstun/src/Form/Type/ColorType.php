namespace App\Form\Type;

// ...
use Symfony\Component\Form\Extension\Core\Type\IntegerType;
use Symfony\Component\Form\FormBuilderInterface;
use Symfony\Component\OptionsResolver\OptionsResolver;

final class ColorType extends AbstractType implements DataMapperInterface
{
    public function buildForm(FormBuilderInterface $builder, array $options): void
    {
        $builder
            ->add('red', IntegerType::class, [
                // enforce the strictness of the type to ensure the constructor
                // of the Color class doesn't break
                'empty_data' => '0',
            ])
            ->add('green', IntegerType::class, [
                'empty_data' => '0',
            ])
            ->add('blue', IntegerType::class, [
                'empty_data' => '0',
            ])
            // configure the data mapper for this FormType
            ->setDataMapper($this)
        ;
    }

    public function configureOptions(OptionsResolver $resolver): void
    {
        // when creating a new color, the initial data should be null
        $resolver->setDefault('empty_data', null);
    }

    // ...
}



public function buildForm(FormBuilderInterface $builder, array $options)
{
    // ...

    $builder->add('state', ChoiceType::class, [
        'choices' => [
            'active' => true,
            'paused' => false,
        ],
        'getter' => function (Task $task, FormInterface $form): bool {
            return !$task->isCancelled() && !$task->isPaused();
        },
        'setter' => function (Task &$task, bool $state, FormInterface $form): void {
            if ($state) {
                $task->activate();
            } else {
                $task->pause();
            }
        },
    ]);
}
